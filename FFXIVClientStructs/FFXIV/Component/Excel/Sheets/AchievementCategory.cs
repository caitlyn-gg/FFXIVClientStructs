// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe partial struct AchievementCategory {
    [FieldOffset(0x00)] public int Name_Offset;
    /// <remarks>AchievementKind</remarks>
    [FieldOffset(0x04)] public byte AchievementKind;
    [FieldOffset(0x05)] public byte Order;
    [FieldOffset(0x06)] public BitField06Flags BitField06;
    public bool ShowComplete => BitField06.HasFlag(BitField06Flags.ShowComplete);
    public bool HideCategory => BitField06.HasFlag(BitField06Flags.HideCategory);

    [Flags]
    public enum BitField06Flags : byte {
    	ShowComplete = 1 << 0,
    	HideCategory = 1 << 1,
    }
}