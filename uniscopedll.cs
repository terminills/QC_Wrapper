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

        public struct s9
        {
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
            public byte f0;
            public byte f1;
            
        }

        public int deviceHandle; 
        public int comPort;
        public int baudRate;



        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void NvToolCallBackDelegate(uint param1, uint param2, uint param3, uint param4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void NvToolCallBack(NvToolCallBackDelegate callback, uint param1, uint param2, uint param3, uint param4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 QCOM_Connect(out Int32 a1, Int32 a2, Int32 a3, Int32 a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void QCOM_Disconnect(ref Int32 a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_DisconnectAll();

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_DLoad_ResetPhone(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_DLoadSendNop(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_EmmcDownloadPrgBootLoader(IntPtr a1, int a2, int a3, IntPtr a4, int a5);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmGsmPolarTxSweepCal(int a1, int a2, int a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetChan(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 QCOM_FtmSetCmdCode(Int32 a1, Int32 a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetMode(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetModeId(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetPdm(int a1, int a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetPowerControl(int a1, int a2, int a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_FtmSetTxStatus(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_GetNVValueStringByEFS(int a1, int a2, uint a3, int a4, int a5, int a6, int a7, [MarshalAs(UnmanagedType.LPStr)] out string a8);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 QCOM_GetPhoneConnStat(ref Int32 a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_GetPhoneMode(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_GetPhoneVersion(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ImeiReadFromPhone(int a1, int a2, ref s6 a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ImeiWriteToPhone(int a1, int a2, ref s9 a3, int a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void QCOM_InitLib(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_MakeGoldenCopy(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_MKDIR(uint a1, int a2, [MarshalAs(UnmanagedType.LPStr)] string a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_NvConfigCallBack(int a1);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_OperateLog(int a1, int a2);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_QcnCheckFile(int ecx, int a2);

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
        public static extern sbyte QCOM_ReadAllNvramFromPhone(int a1);
        
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNvramFromPhone(int a1, IntPtr a2, IntPtr a3, IntPtr a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadFileFromEFS(int a1, uint a2, int a3);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadMemFromEFS(int a1, ref int a2, int a3, uint a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNVItemFromMobileByEFS(int a1, uint a2, int a3, [MarshalAs(UnmanagedType.LPStr)] string a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNvramFromPhone(int a1, IntPtr a2, ref s0 a3, [MarshalAs(UnmanagedType.LPStr)] string a4);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int QCOM_ReadNvramFromPhone_EXT(int a1, IntPtr a2, ref s0 a3, [MarshalAs(UnmanagedType.LPStr)] string a4);

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
        public static extern int QCOM_SetNVValueStringByEFS(int a1, uint a2, int a3, int v4, int v5, int v6);

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint QCOM_SetPhoneMode(IntPtr a1, int a2);

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

            int result = UniscopeQCLibrary.QCOM_ReadNvramFromPhone(a1, a2, a3, a4);

            Console.WriteLine($"QCOM_ReadNvramFromPhone result: {result}");

        }

        public int ConnectToDevice()
        {
            int result = QCOM_Connect(out deviceHandle, comPort, baudRate, 0);
            // Handle the connection result and return status
            return result;
        }

        public static bool ScanForDevices(out int deviceHandle)
        {
            UniscopeQCLibrary uniscopeLibrary = new UniscopeQCLibrary();
            uniscopeLibrary.comPort = 16; // Set the desired COM port
            uniscopeLibrary.baudRate = 9600; // Set the desired baud rate

            int connectionResult = uniscopeLibrary.ConnectToDevice();

            int result = UniscopeQCLibrary.QCOM_Connect(out deviceHandle, uniscopeLibrary.comPort, uniscopeLibrary.baudRate, 0);

            if (result == 0)
            {
                Console.WriteLine("Device connected!");
                return true;
            }
            else
            {
                Console.WriteLine("Device not found or connection error.");
                return false;
            }
        }


    }
}
