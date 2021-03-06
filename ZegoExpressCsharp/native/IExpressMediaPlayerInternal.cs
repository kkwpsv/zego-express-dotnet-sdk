﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ZEGO
{
    class IExpressMediaPlayerInternal
    {
        /// Return Type: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_destroy_media_player", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_destroy_media_player(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_start", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_start(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_stop", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_stop(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_pause", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_pause(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_resume", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_resume(ZegoMediaPlayerInstanceIndex instance_index);


       
        /// Return Type: zego_mediaplayer_state
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_get_current_state", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern ZegoMediaPlayerState zego_express_media_player_get_current_state(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///param0: unsigned int
        ///millisecond: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_seek_to", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_seek_to(ulong millisecond, ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///volume: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_set_volume", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_set_volume(int volume, ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_get_volume", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_get_volume(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: unsigned int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_get_total_duration", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern uint zego_express_media_player_get_total_duration(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: unsigned int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_get_current_progress", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern uint zego_express_media_player_get_current_progress(ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///mute: boolean
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_mute_local_audio", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_mute_local_audio([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool mute, ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///canvas: zego_canvas*
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_set_player_canvas", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_set_player_canvas(IntPtr canvas, ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///enable: boolean
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_enable_aux", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_enable_aux([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool enable, ZegoMediaPlayerInstanceIndex instance_index);



        /// Return Type: int
        ///enable: boolean
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_enable_repeat", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_enable_repeat([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool enable, ZegoMediaPlayerInstanceIndex instance_index);

        /// Return Type: int
        ///param0: unsigned int
        ///millisecond: int
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_set_progress_interval", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_set_progress_interval(ulong millisecond, ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///enable: boolean
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_enable_audio_data", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_enable_audio_data([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool enable, ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: int
        ///enable: boolean
        ///format: zego_video_frame_format
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_enable_video_data", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_enable_video_data([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.I1)] bool enable, ZegoVideoFrameFormat format, ZegoMediaPlayerInstanceIndex instance_index);


        /// Return Type: void
        ///callback_func: zego_on_mediaplayer_audio_data
        ///user_context: void*
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_register_media_player_audio_frame_callback", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern void zego_register_media_player_audio_frame_callback(zego_on_media_player_audio_frame callback_func, System.IntPtr user_context);


        /// Return Type: void
        ///callback_func: zego_on_mediaplayer_video_data
        ///user_context: void*
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_register_media_player_video_frame_callback", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern void zego_register_media_player_video_frame_callback(zego_on_media_player_video_frame callback_func, System.IntPtr user_context);

       
        
        
        /// Return Type: int
        ///path: char*
        ///instance_index: zego_mediaplayer_instance_index
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_media_player_load_resource", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern int zego_express_media_player_load_resource([System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.CustomMarshaler,MarshalTypeRef =typeof(ZegoUtil.UTF8StringMarshaler))] string path, ZegoMediaPlayerInstanceIndex instance_index);

        /// Return Type: ZegoMediaPlayerInstanceIndex
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_express_create_media_player", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern ZegoMediaPlayerInstanceIndex zego_express_create_media_player();

        /// Return Type: void
        ///callback_func: zego_on_mediaplayer_state_update
        ///user_context: void*
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_register_media_player_state_update_callback", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern void zego_register_media_player_state_update_callback(zego_on_media_player_state_update callback_func, System.IntPtr user_context);


        /// Return Type: void
        ///callback_func: zego_on_mediaplayer_network_event
        ///user_context: void*
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_register_media_player_network_event_callback", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern void zego_register_media_player_network_event_callback(zego_on_media_player_network_event callback_func, System.IntPtr user_context);


        /// Return Type: void
        ///callback_func: zego_on_mediaplayer_playing_progress
        ///user_context: void*
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_register_media_player_playing_progress_callback", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern void zego_register_media_player_playing_progress_callback(zego_on_media_player_playing_progress callback_func, System.IntPtr user_context);


        /// Return Type: void
        ///callback_func: zego_on_mediaplayer_seek_to_time_result
        ///user_context: void*
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_register_media_player_seek_to_callback", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern void zego_register_media_player_seek_to_callback(zego_on_media_player_seek_to callback_func, System.IntPtr user_context);


        /// Return Type: void
        ///callback_func: zego_on_mediaplayer_load_resource_result
        ///user_context: void*
        [DllImportAttribute(ZegoConstans.LIB_NAME, EntryPoint = "zego_register_media_player_load_resource_callback", CallingConvention = ZegoConstans.ZEGO_CALINGCONVENTION)]
        public static extern void zego_register_media_player_load_resource_callback(zego_on_media_player_load_resource callback_func, System.IntPtr user_context);





        /// Return Type: void
        ///state: ZegoMediaPlayerState
        ///error_code: int
        ///instance_index: ZegoMediaPlayerInstanceIndex
        ///user_context: void*
        [UnmanagedFunctionPointer(ZegoConstans.ZEGO_CALINGCONVENTION)]
        public delegate void zego_on_media_player_state_update(ZegoMediaPlayerState state, int error_code, ZegoMediaPlayerInstanceIndex instance_index, System.IntPtr user_context);

        /// Return Type: void
        ///event: ZegoMediaPlayerNetworkEvent
        ///instance_index: ZegoMediaPlayerInstanceIndex
        ///user_context: void*
        [UnmanagedFunctionPointer(ZegoConstans.ZEGO_CALINGCONVENTION)]
        public delegate void zego_on_media_player_network_event(ZegoMediaPlayerNetworkEvent net_event, ZegoMediaPlayerInstanceIndex instance_index, System.IntPtr user_context);

        /// Return Type: void
        ///param0: unsigned int
        ///millisecond: int
        ///instance_index: ZegoMediaPlayerInstanceIndex
        ///user_context: void*
        [UnmanagedFunctionPointer(ZegoConstans.ZEGO_CALINGCONVENTION)]
        public delegate void zego_on_media_player_playing_progress(ulong millisecond, ZegoMediaPlayerInstanceIndex instance_index, System.IntPtr user_context);

        /// Return Type: void
        ///seq: int
        ///error_code: int
        ///instance_index: ZegoMediaPlayerInstanceIndex
        ///user_context: void*
        [UnmanagedFunctionPointer(ZegoConstans.ZEGO_CALINGCONVENTION)]
        public delegate void zego_on_media_player_seek_to(int seq, int error_code, ZegoMediaPlayerInstanceIndex instance_index, System.IntPtr user_context);

        /// Return Type: void
        ///error_code: int
        ///instance_index: ZegoMediaPlayerInstanceIndex
        ///user_context: void*
        [UnmanagedFunctionPointer(ZegoConstans.ZEGO_CALINGCONVENTION)]
        public delegate void zego_on_media_player_load_resource(int error_code, ZegoMediaPlayerInstanceIndex instance_index, System.IntPtr user_context);

        /// Return Type: void
        ///data: char*
        ///data_length: unsigned int
        ///param: zego_audio_frame_param
        ///instance_index: ZegoMediaPlayerInstanceIndex
        ///user_context: void*
        [UnmanagedFunctionPointer(ZegoConstans.ZEGO_CALINGCONVENTION)]
        public delegate void zego_on_media_player_audio_frame(IntPtr data, uint data_length, zego_audio_frame_param param, ZegoMediaPlayerInstanceIndex instance_index, System.IntPtr user_context);

        /// Return Type: void
        ///data: char**
        ///data_length: unsigned int*
        ///param: zego_video_frame_param
        ///instance_index: ZegoMediaPlayerInstanceIndex
        ///user_context: void*
        [UnmanagedFunctionPointer(ZegoConstans.ZEGO_CALINGCONVENTION)]
        public delegate void zego_on_media_player_video_frame([In][MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] IntPtr[] data,
            [In][MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] uint[] data_length, zego_video_frame_param param,
            ZegoMediaPlayerInstanceIndex instance_index, System.IntPtr user_context);



    }
}
