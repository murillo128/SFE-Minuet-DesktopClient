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
    internal unsafe struct cef_request_context_t
    {
        internal cef_base_t _base;
        internal IntPtr _is_same;
        internal IntPtr _is_sharing_with;
        internal IntPtr _is_global;
        internal IntPtr _get_handler;
        internal IntPtr _get_cache_path;
        internal IntPtr _get_default_cookie_manager;
        internal IntPtr _register_scheme_handler_factory;
        internal IntPtr _clear_scheme_handler_factories;
        internal IntPtr _purge_plugin_list_cache;
        internal IntPtr _has_preference;
        internal IntPtr _get_preference;
        internal IntPtr _get_all_preferences;
        internal IntPtr _can_set_preference;
        internal IntPtr _set_preference;
        internal IntPtr _clear_certificate_exceptions;
        internal IntPtr _close_all_connections;
        internal IntPtr _resolve_host;
        internal IntPtr _resolve_host_cached;
        
        // GetGlobalContext
        [DllImport(libcef.DllName, EntryPoint = "cef_request_context_get_global_context", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_request_context_t* get_global_context();
        
        // CreateContext
        [DllImport(libcef.DllName, EntryPoint = "cef_request_context_create_context", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_request_context_t* create_context(cef_request_context_settings_t* settings, cef_request_context_handler_t* handler);
        
        // CreateContext
        [DllImport(libcef.DllName, EntryPoint = "cef_create_context_shared", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_request_context_t* create_context(cef_request_context_t* other, cef_request_context_handler_t* handler);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_request_context_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_request_context_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_request_context_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_same_delegate(cef_request_context_t* self, cef_request_context_t* other);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_sharing_with_delegate(cef_request_context_t* self, cef_request_context_t* other);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_global_delegate(cef_request_context_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_request_context_handler_t* get_handler_delegate(cef_request_context_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_cache_path_delegate(cef_request_context_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_cookie_manager_t* get_default_cookie_manager_delegate(cef_request_context_t* self, cef_completion_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int register_scheme_handler_factory_delegate(cef_request_context_t* self, cef_string_t* scheme_name, cef_string_t* domain_name, cef_scheme_handler_factory_t* factory);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int clear_scheme_handler_factories_delegate(cef_request_context_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void purge_plugin_list_cache_delegate(cef_request_context_t* self, int reload_pages);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_preference_delegate(cef_request_context_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_value_t* get_preference_delegate(cef_request_context_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_dictionary_value_t* get_all_preferences_delegate(cef_request_context_t* self, int include_defaults);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int can_set_preference_delegate(cef_request_context_t* self, cef_string_t* name);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int set_preference_delegate(cef_request_context_t* self, cef_string_t* name, cef_value_t* value, cef_string_t* error);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void clear_certificate_exceptions_delegate(cef_request_context_t* self, cef_completion_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void close_all_connections_delegate(cef_request_context_t* self, cef_completion_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void resolve_host_delegate(cef_request_context_t* self, cef_string_t* origin, cef_resolve_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefErrorCode resolve_host_cached_delegate(cef_request_context_t* self, cef_string_t* origin, cef_string_list* resolved_ips);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_request_context_t* self)
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
        
        public static int release(cef_request_context_t* self)
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
        
        public static int has_one_ref(cef_request_context_t* self)
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
        
        // IsSame
        private static IntPtr _p3;
        private static is_same_delegate _d3;
        
        public static int is_same(cef_request_context_t* self, cef_request_context_t* other)
        {
            is_same_delegate d;
            var p = self->_is_same;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_same_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_same_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self, other);
        }
        
        // IsSharingWith
        private static IntPtr _p4;
        private static is_sharing_with_delegate _d4;
        
        public static int is_sharing_with(cef_request_context_t* self, cef_request_context_t* other)
        {
            is_sharing_with_delegate d;
            var p = self->_is_sharing_with;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (is_sharing_with_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_sharing_with_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self, other);
        }
        
        // IsGlobal
        private static IntPtr _p5;
        private static is_global_delegate _d5;
        
        public static int is_global(cef_request_context_t* self)
        {
            is_global_delegate d;
            var p = self->_is_global;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (is_global_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_global_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // GetHandler
        private static IntPtr _p6;
        private static get_handler_delegate _d6;
        
        public static cef_request_context_handler_t* get_handler(cef_request_context_t* self)
        {
            get_handler_delegate d;
            var p = self->_get_handler;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_handler_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_handler_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // GetCachePath
        private static IntPtr _p7;
        private static get_cache_path_delegate _d7;
        
        public static cef_string_userfree* get_cache_path(cef_request_context_t* self)
        {
            get_cache_path_delegate d;
            var p = self->_get_cache_path;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (get_cache_path_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_cache_path_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // GetDefaultCookieManager
        private static IntPtr _p8;
        private static get_default_cookie_manager_delegate _d8;
        
        public static cef_cookie_manager_t* get_default_cookie_manager(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            get_default_cookie_manager_delegate d;
            var p = self->_get_default_cookie_manager;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (get_default_cookie_manager_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_default_cookie_manager_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self, callback);
        }
        
        // RegisterSchemeHandlerFactory
        private static IntPtr _p9;
        private static register_scheme_handler_factory_delegate _d9;
        
        public static int register_scheme_handler_factory(cef_request_context_t* self, cef_string_t* scheme_name, cef_string_t* domain_name, cef_scheme_handler_factory_t* factory)
        {
            register_scheme_handler_factory_delegate d;
            var p = self->_register_scheme_handler_factory;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (register_scheme_handler_factory_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(register_scheme_handler_factory_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self, scheme_name, domain_name, factory);
        }
        
        // ClearSchemeHandlerFactories
        private static IntPtr _pa;
        private static clear_scheme_handler_factories_delegate _da;
        
        public static int clear_scheme_handler_factories(cef_request_context_t* self)
        {
            clear_scheme_handler_factories_delegate d;
            var p = self->_clear_scheme_handler_factories;
            if (p == _pa) { d = _da; }
            else
            {
                d = (clear_scheme_handler_factories_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(clear_scheme_handler_factories_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self);
        }
        
        // PurgePluginListCache
        private static IntPtr _pb;
        private static purge_plugin_list_cache_delegate _db;
        
        public static void purge_plugin_list_cache(cef_request_context_t* self, int reload_pages)
        {
            purge_plugin_list_cache_delegate d;
            var p = self->_purge_plugin_list_cache;
            if (p == _pb) { d = _db; }
            else
            {
                d = (purge_plugin_list_cache_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(purge_plugin_list_cache_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            d(self, reload_pages);
        }
        
        // HasPreference
        private static IntPtr _pc;
        private static has_preference_delegate _dc;
        
        public static int has_preference(cef_request_context_t* self, cef_string_t* name)
        {
            has_preference_delegate d;
            var p = self->_has_preference;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (has_preference_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_preference_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            return d(self, name);
        }
        
        // GetPreference
        private static IntPtr _pd;
        private static get_preference_delegate _dd;
        
        public static cef_value_t* get_preference(cef_request_context_t* self, cef_string_t* name)
        {
            get_preference_delegate d;
            var p = self->_get_preference;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (get_preference_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_preference_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            return d(self, name);
        }
        
        // GetAllPreferences
        private static IntPtr _pe;
        private static get_all_preferences_delegate _de;
        
        public static cef_dictionary_value_t* get_all_preferences(cef_request_context_t* self, int include_defaults)
        {
            get_all_preferences_delegate d;
            var p = self->_get_all_preferences;
            if (p == _pe) { d = _de; }
            else
            {
                d = (get_all_preferences_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_all_preferences_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            return d(self, include_defaults);
        }
        
        // CanSetPreference
        private static IntPtr _pf;
        private static can_set_preference_delegate _df;
        
        public static int can_set_preference(cef_request_context_t* self, cef_string_t* name)
        {
            can_set_preference_delegate d;
            var p = self->_can_set_preference;
            if (p == _pf) { d = _df; }
            else
            {
                d = (can_set_preference_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(can_set_preference_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            return d(self, name);
        }
        
        // SetPreference
        private static IntPtr _p10;
        private static set_preference_delegate _d10;
        
        public static int set_preference(cef_request_context_t* self, cef_string_t* name, cef_value_t* value, cef_string_t* error)
        {
            set_preference_delegate d;
            var p = self->_set_preference;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (set_preference_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_preference_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            return d(self, name, value, error);
        }
        
        // ClearCertificateExceptions
        private static IntPtr _p11;
        private static clear_certificate_exceptions_delegate _d11;
        
        public static void clear_certificate_exceptions(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            clear_certificate_exceptions_delegate d;
            var p = self->_clear_certificate_exceptions;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (clear_certificate_exceptions_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(clear_certificate_exceptions_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            d(self, callback);
        }
        
        // CloseAllConnections
        private static IntPtr _p12;
        private static close_all_connections_delegate _d12;
        
        public static void close_all_connections(cef_request_context_t* self, cef_completion_callback_t* callback)
        {
            close_all_connections_delegate d;
            var p = self->_close_all_connections;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (close_all_connections_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(close_all_connections_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            d(self, callback);
        }
        
        // ResolveHost
        private static IntPtr _p13;
        private static resolve_host_delegate _d13;
        
        public static void resolve_host(cef_request_context_t* self, cef_string_t* origin, cef_resolve_callback_t* callback)
        {
            resolve_host_delegate d;
            var p = self->_resolve_host;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (resolve_host_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(resolve_host_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            d(self, origin, callback);
        }
        
        // ResolveHostCached
        private static IntPtr _p14;
        private static resolve_host_cached_delegate _d14;
        
        public static CefErrorCode resolve_host_cached(cef_request_context_t* self, cef_string_t* origin, cef_string_list* resolved_ips)
        {
            resolve_host_cached_delegate d;
            var p = self->_resolve_host_cached;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (resolve_host_cached_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(resolve_host_cached_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            return d(self, origin, resolved_ips);
        }
        
    }
}
