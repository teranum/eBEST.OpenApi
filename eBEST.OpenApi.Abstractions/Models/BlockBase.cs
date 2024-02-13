using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace eBEST.Abstractions;

public abstract record BlockBase(int TotalSize)
{
    public byte[] ToMemory()
    {
        Type type = GetType();
        var parameters = type.GetConstructors()[0].GetParameters();

        byte[] result = new byte[TotalSize];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0x20;
        }

        int pos = 0;
        foreach (var parameter in parameters)
        {
            var attr = parameter.GetCustomAttribute<BlockFieldAttribute>()!;
            // StartPos, Length를 참조하여 byte[]로 변환
            PropertyInfo propertyInfo = type.GetProperty(parameter.Name!)!;
            object value = propertyInfo.GetValue(this)!;
            string text = value.ToString()!;
            byte[] bytes = System.Text.Encoding.Default.GetBytes(text);
            int size = (int)attr.Size;
            for (int i = 0, lenIndex = 0; i < bytes.Length && lenIndex < size; i++, lenIndex++)
            {
                result[pos + i] = bytes[i];
            }
            pos += size + 1;

        }
        Debug.Assert(pos == TotalSize);

        return result;
    }

    public static object FromMemory(Type type, byte[] array, int start)
    {
        var parameters = type.GetConstructors()[0].GetParameters();
        object[] param_vals = new object[parameters.Length];
        int pos = 0;
        for (int i = 0; i < parameters.Length; i++)
        {
            var attr = parameters[i].GetCustomAttribute<BlockFieldAttribute>();
            if (attr == null)
                throw new NotSupportedException($"{parameters[i].Name} is not defined BlockFiled, must be defined");
            int size = (int)attr.Size;
            string value = ByteToString(array, start + pos, size);
            param_vals[i] = Convert.ChangeType(value, parameters[i].ParameterType!);
            pos += size + 1;
        }

        return Activator.CreateInstance(type, param_vals)!;
    }
    public static string ByteToString(byte[] bytes, int start, int len)
    {
        return Marshal.PtrToStringAnsi(Marshal.UnsafeAddrOfPinnedArrayElement(bytes, start), len)!;
    }
}
