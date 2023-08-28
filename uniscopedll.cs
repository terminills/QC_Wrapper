/*
 * UniscopeQCLibrary - Wrapper for QCOM Library Functions
 *
 * This wrapper provides an interface to interact with the QCOM library functions
 * for communicating with Qualcomm devices. It includes functions for connecting
 * to devices, reading and writing IMEI, and other device-related operations.
 *
 * IMEIStruct Fields:
 * - Padding: A padding byte for alignment.
 * - FirstDigit: The first digit of the IMEI.
 * - SecondDigit: The second digit of the IMEI.
 * - ThirdDigit: The third digit of the IMEI.
 * - ... and so on for the remaining digits of the IMEI.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <https://www.gnu.org/licenses/>.
 *
 * Author: Timothy Deters
 * Date: 8/27/2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UniscopeQCWrapper
{
    public class UniscopeQCLibrary
    {
        const string DllPath = "UniscopeQC.dll";

        private const int ConnectFunctionId = 0xe636;
        private const int ImeiReadFunctionId = 0xe5d6;
        private const int GetPhoneConnStatFunctionId = 0xe646;
        private const int GetPhoneModeFunctionId = 0xe622;
        private const int ReadNvramFunctionId = 0xe608;
        private const int ImeiWriteFunctionId = 0xe5f0;
        private const int WriteNvramFunctionId = 0xe5bc;
        private const int GetPhoneVersionFunctionId = 0xe5a4;

        public struct IMEIStruct
        {
            [MarshalAs(UnmanagedType.U1)]
            public byte Padding;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte FirstDigit;
            
            [MarshalAs(UnmanagedType.U1)]
            public byte SecondDigit;
            
            [MarshalAs(UnmanagedType.U1)]
            public byte ThirdDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FourthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FifthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte SixthDigit;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte SeventhDigit;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte EigthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte NinthDigit;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte TenthDigit;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte EleventhDigit;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte TwelfthDigit;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte ThirteenthDigit;
                        
            [MarshalAs(UnmanagedType.U1)]
            public byte FourteenthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FifteenthDigit;

        }

        public struct ImeiReadData
        {
            [MarshalAs(UnmanagedType.U1)]
            public byte Padding;

            [MarshalAs(UnmanagedType.U1)]
            public byte FirstDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte SecondDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte ThirdDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FourthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FifthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte SixthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte SeventhDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte EigthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte NinthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte TenthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte EleventhDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte TwelfthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte ThirteenthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FourteenthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FifteenthDigit;

        }

        public struct NvramData
        {
            public int Field1;  
            public byte Field2; 
        }

        public struct A1Data
        {
            [MarshalAs(UnmanagedType.U1)]
            public byte Padding;

            [MarshalAs(UnmanagedType.U1)]
            public byte FirstDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte SecondDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte ThirdDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FourthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FifthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte SixthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte SeventhDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte EigthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte NinthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte TenthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte EleventhDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte TwelfthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte ThirteenthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FourteenthDigit;

            [MarshalAs(UnmanagedType.U1)]
            public byte FifteenthDigit;
        } // Old: a1


        public struct s9
        {
            public byte pad1;
            public byte f0;
            public byte f1;
            
        }

        public struct s6
        {
            public byte f0;
            public byte f1;
            
        }

        public struct s0
        {
            
        }

        public struct a1
        {
            public byte pad1;
            public byte f0;
            public byte f1;
            // Add more fields if needed to match the struct's size and layout
        }

        public int deviceHandle; // To hold the device handle
        public int comPort;
        public int baudRate;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void NvToolCallBackDelegate(uint param1, uint param2, uint param3, uint param4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void NvToolCallBack(NvToolCallBackDelegate callback, uint param1, uint param2, uint param3, uint param4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 QCOM_Connect(out Int32 deviceHandle, Int32 comPort, Int32 baudRate, Int32 timeout);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void QCOM_Disconnect(ref Int32 deviceHandle);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_DisconnectAll();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_DLoad_ResetPhone(int deviceHandle);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_DLoadSendNop(int deviceHandle);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_EmmcDownloadPrgBootLoader(IntPtr deviceHandle, int a2, int a3, IntPtr a4, int a5);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmGsmPolarTxSweepCal(int deviceHandle, int a2, int a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetChan(int deviceHandle, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 QCOM_FtmSetCmdCode(Int32 deviceHandle, Int32 a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetMode(int deviceHandle, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetModeId(int deviceHandle, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetPdm(int deviceHandle, int a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetPowerControl(int deviceHandle, int a2, int a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetTxStatus(int deviceHandle, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_GetNVValueStringByEFS(int deviceHandle, int a2, uint a3, int a4, int a5, int a6, int a7, [MarshalAs(UnmanagedType.LPStr)] out string a8);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 QCOM_GetPhoneConnStat(ref Int32 deviceHandle);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_GetPhoneMode(int deviceHandle, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_GetPhoneVersion(int deviceHandle, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ImeiReadFromPhone(int deviceHandle, int a2, ref IMEIStruct imeiStruct, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ImeiWriteToPhone(int deviceHandle, int a2, ref IMEIStruct imeiStruct, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void QCOM_InitLib(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_MakeGoldenCopy(int deviceHandle);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_MKDIR(uint a1, int a2, [MarshalAs(UnmanagedType.LPStr)] string a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_NvConfigCallBack(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_OperateLog(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_QcnCheckFile(int deviceHandle, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_QcnLoadFromFile();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_QcnLoadNvXmlFile(int a2, int a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_QcnLoadOperation();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_QcnLoadOperationAll();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_QcnWriteToPhone();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte QCOM_ReadAllNvramFromPhone(int deviceHandle);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNvramFromPhone(int deviceHandle, IntPtr buffer, IntPtr bufferSize, IntPtr nvItemId);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadFileFromEFS(int a1, uint a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadMemFromEFS(int a1, ref int a2, int a3, uint a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNVItemFromMobileByEFS(int a1, uint a2, int a3, [MarshalAs(UnmanagedType.LPStr)] string a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNvramFromPhone(int deviceHandle, IntPtr a2, ref NvramData a3, [MarshalAs(UnmanagedType.LPStr)] string a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNvramFromPhone_EXT(int a1, IntPtr a2, ref NvramData a3, [MarshalAs(UnmanagedType.LPStr)] string a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_REMOVEDIR(uint a1, int a2, [MarshalAs(UnmanagedType.LPStr)] string a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_RtreReadFromPhone(int a1, ref int a2, [MarshalAs(UnmanagedType.LPStr)] string a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte QCOM_RtreWriteToPhone(UInt32 ecx, Int32 a2, sbyte a3, [MarshalAs(UnmanagedType.LPStr)] string a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_SB1MultiImageUpload(int ecx, int a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_SendSpcCmdToPhone(int ecx, int a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_SendSyncString(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint QCOM_SetFactoryToken(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_SetNVOnline(int a1, string a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_SetNVValueStringByEFS(
            int a1,
            uint a2,
            int a3,
            int v4,
            int v5,
            int v6
        );

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_SetPhoneMode(
            IntPtr a1, // Not specified in the gathered data
            int a2
        );

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint QCOM_SwitchToDownloadMode(IntPtr a1, int a2, IntPtr a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint QCOM_SwitchToDownloadMode_OptionalValidation(IntPtr a1, int a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_SyncWithWait(uint ecx, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_WriteFileToEFS(int a1, uint a2, int a3, sbyte[] a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_WriteMemToEFS(int a1, int a2, uint a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_WriteNVItemToMobileByEFS(int a1, uint a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void QCOM_WriteNvramToPhone(int ecx, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void QCOM_WriteNvramToPhone2(int ecx, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_WriteNvramToPhone_EXT(int ecx, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 QCOM_TestAPIs(IntPtr a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_UploadQcnFile(int a1, int a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void fun_10006396(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void fun_1000637e(int a1, string format, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void fun_10006360(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void fun_40b1c0();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void fun_40b102();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Sleep(int milliseconds);


        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern int fun_409aba(IntPtr a1, int a2, int a3, int a4, IntPtr a5, IntPtr a6);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern uint fun_409aa2(int a1, int a2, IntPtr a3, IntPtr a4, IntPtr a5, IntPtr a6, IntPtr a7, IntPtr a8);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern int fun_409ac0(IntPtr a1, IntPtr a2, IntPtr a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern int fun_409ab4(IntPtr a1, IntPtr a2, IntPtr a3, IntPtr a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern uint fun_409aae(int a1, uint a2, IntPtr a3, IntPtr a4, IntPtr a5, IntPtr a6, IntPtr a7, IntPtr a8);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern int fun_409aa8(int a1, int a2, IntPtr a3, IntPtr a4, IntPtr a5, IntPtr a6, IntPtr a7, IntPtr a8);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern int fun_409a9c(int a1, uint a2, IntPtr a3, IntPtr a4, int a5, IntPtr a6, IntPtr a7, IntPtr a8, IntPtr a9);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr fun_409a96(int a1, IntPtr a2, IntPtr a3, IntPtr a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetTimer(IntPtr hwnd, int idTimer, int uElapse, IntPtr lpTimerFunc);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void esi13(uint param1, string format, params object[] args);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ebx15(params string[] args);

        public void CallFun_40b1c0()
        {
            fun_40b1c0();
        }
        
        public void CallFun_40b102()
        {
            fun_40b102();
        }

        public void CallSleep(int milliseconds)
        {
            Sleep(milliseconds);
        }

        public int CallSetTimer(IntPtr hwnd, int idTimer, int uElapse, IntPtr lpTimerFunc)
        {
            return SetTimer(hwnd, idTimer, uElapse, lpTimerFunc);
        }

        // Disconnects the device
        

        public static void WriteIMEIAndEnable(string comPort, string imei)
        {
            // Define other necessary variables
            string v21 = "0"; // Define the actual value

            // Prepare the arguments
            string esp27 = "0"; // Define the actual value
            string esp24 = "0"; // Define the actual value
            string esp20 = "0"; // Define the actual value

            // Convert the IMEI to bytes if necessary
            byte[] imeiBytes = Encoding.ASCII.GetBytes(imei);

            // Call the functions
            ebx15("WriteIMEI1", "Enable", esp27 + 20, v21, "Branch2", "COMPortSelect", esp24 + 20, v21, "Branch2", "Enable", esp20 + 20, v21, "Branch1", "COMPortSelect");
            esi13(Convert.ToUInt32(esp27) + 20, "%d", v21, "WriteIMEI1", "Enable", esp27 + 20, v21, "Branch2", "COMPortSelect", esp24 + 20, v21, "Branch2", "Enable", esp20 + 20, v21, "Branch1", "COMPortSelect");
        }






        public static void TestNvToolCallBack(uint param1, uint param2, uint param3, uint param4)
        {
            Console.WriteLine($"NvToolCallBack params: {param1}, {param2}, {param3}, {param4}");
        }

        public static void TestQCOMFunctions()
        {
            Console.WriteLine("Results:");

            int a1 = 123;
            IntPtr a2 = IntPtr.Zero;
            IntPtr a3 = IntPtr.Zero;
            IntPtr a4 = IntPtr.Zero;

            int result = QCOM_ReadNvramFromPhone(a1, a2, a3, a4);

            Console.WriteLine($"QCOM_ReadNvramFromPhone result: {result}");
        }

        private static int Connect(IntPtr a1, int a2, int a3, int a4, IntPtr a5, IntPtr a6)
        {
            return fun_409aba(a1, a2, a3, a4, a5, a6);
        }

        // Public methods to be used by the user of the wrapper class
        public int PerformConnect(IntPtr a1, int a2, int a3, int a4, IntPtr a5, IntPtr a6)
        {
            return Connect(a1, a2, a3, a4, a5, a6);
        }

        public int ConnectToDevice()
        {
            Console.WriteLine("Entering ConnectToDevice...");

            // Establish a connection with the device
            int result = QCOM_Connect(out deviceHandle, comPort, baudRate, 0);


            if (result == 0)
            {
                // Connection successful, provide verbose information
                Console.WriteLine("Device connected successfully!");
                Console.WriteLine($"Connected COM port: {comPort}");
                Console.WriteLine($"Baud rate: {baudRate}");
            }
            else
            {
                // Connection failed, provide verbose error information
                Console.WriteLine("Device connection error.");
            }

            Console.WriteLine("Leaving ConnectToDevice...");

            // Return the connection result
            return result;
        }

        public static bool ReadIMEI(int deviceHandle, out string imei)
        {
            imei = string.Empty;
            const int nvItemId = 550;
            int bufferSize = 16; // Adjust this to the correct size based on the expected data

            IntPtr bufferPtr = Marshal.AllocHGlobal(bufferSize);
            IntPtr bufferSizePtr = (IntPtr)bufferSize;

            try
            {
                // Initialize the connection with the provided device handle
                int connectionResult = QCOM_Connect(out deviceHandle, 0, 0, 0);
                if (connectionResult != 0)
                {
                    Console.WriteLine("Error connecting to device.");
                    return false;
                }

                Console.WriteLine("Device connected successfully!");

                // Now, proceed with the read operation
                int result = QCOM_ReadNvramFromPhone(deviceHandle, bufferPtr, bufferSizePtr, (IntPtr)nvItemId);

                if (result == 0) // Assuming 0 indicates success, update this based on your DLL's return value
                {
                    imei = Marshal.PtrToStringAnsi(bufferPtr);
                }

                return result == 0;
            }
            finally
            {
                Marshal.FreeHGlobal(bufferPtr);
            }
        }

        public static bool ScanForDevices(out List<int> deviceHandles)
        {
            deviceHandles = new List<int>();
            UniscopeQCLibrary uniscopeLibrary = new UniscopeQCLibrary();
            uniscopeLibrary.comPort = 0; // Auto-detect COM port
            uniscopeLibrary.baudRate = 38400; // Set the desired baud rate

            int connectionResult = uniscopeLibrary.ConnectToDevice();

            Console.WriteLine("Scanning for devices...");

            // Scan for devices and store their handles
            for (int comPort = 1; comPort <= 256; comPort++)
            {
                int result = QCOM_Connect(out int deviceHandle, comPort, uniscopeLibrary.baudRate, 0);
                if (result == 0)
                {
                    Console.WriteLine($"Device connected successfully on COM port: {comPort}");
                    Console.WriteLine($"Baud rate: {uniscopeLibrary.baudRate}");
                    deviceHandles.Add(deviceHandle);
                }
                else
                {
                    Console.WriteLine($"No device found on COM port: {comPort}");
                }
            }

            return deviceHandles.Count > 0;
        }
    }
}
