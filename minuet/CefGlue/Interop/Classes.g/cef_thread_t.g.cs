//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_thread_t
    {
        internal cef_base_t _base;
        internal IntPtr _get_task_runner;
        internal IntPtr _get_platform_thread_id;
        internal IntPtr _stop;
        internal IntPtr _is_running;
        
        // CreateThread
        [DllImport(libcef.DllName, EntryPoint = "cef_thread_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_thread_t* create(cef_string_t* display_name, cef_thread_priority_t priority, cef_message_loop_type_t message_loop_type, int stoppable, cef_com_init_mode_t com_init_mode);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_thread_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_thread_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_thread_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_task_runner_t* get_task_runner_delegate(cef_thread_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_platform_thread_id_t get_platform_thread_id_delegate(cef_thread_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void stop_delegate(cef_thread_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_running_delegate(cef_thread_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_thread_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_thread_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_thread_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // GetTaskRunner
        private static IntPtr _p3;
        private static get_task_runner_delegate _d3;
        
        public static cef_task_runner_t* get_task_runner(cef_thread_t* self)
        {
            get_task_runner_delegate d;
            var p = self->_get_task_runner;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (get_task_runner_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_task_runner_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // GetPlatformThreadId
        private static IntPtr _p4;
        private static get_platform_thread_id_delegate _d4;
        
        public static cef_platform_thread_id_t get_platform_thread_id(cef_thread_t* self)
        {
            get_platform_thread_id_delegate d;
            var p = self->_get_platform_thread_id;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_platform_thread_id_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_platform_thread_id_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // Stop
        private static IntPtr _p5;
        private static stop_delegate _d5;
        
        public static void stop(cef_thread_t* self)
        {
            stop_delegate d;
            var p = self->_stop;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (stop_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(stop_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            d(self);
        }
        
        // IsRunning
        private static IntPtr _p6;
        private static is_running_delegate _d6;
        
        public static int is_running(cef_thread_t* self)
        {
            is_running_delegate d;
            var p = self->_is_running;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (is_running_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_running_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
    }
}
