﻿using System;
using System.Runtime.InteropServices;

namespace RazerSdkReader.Structures;

/// <summary>
///     Unused. Kept for completeness.
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public readonly record struct CChromaDeviceData
{
    public readonly int Count;
    public readonly CChromaDeviceDataInfo50 Device;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public readonly record struct CChromaDeviceDataInfo
{
    public readonly CChromaString Instance;
    public readonly CChromaString EventName;
    public readonly CChromaString FileName;
    public readonly CChromaString ModuleName;
    public readonly CChromaString DevicePath;
    public readonly Guid DeviceId;
}

[UnmanagedArray(typeof(CChromaDeviceDataInfo), 50)]
public readonly partial record struct CChromaDeviceDataInfo50;