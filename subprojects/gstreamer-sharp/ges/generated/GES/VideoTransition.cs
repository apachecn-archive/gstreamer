// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VideoTransition : GES.Transition {

		public VideoTransition (IntPtr raw) : base(raw) {}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_video_transition_new();

		public VideoTransition () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (VideoTransition)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = ges_video_transition_new();
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_video_transition_get_border(IntPtr raw);

		[Obsolete]
		[GLib.Property ("border")]
		public int Border {
			get  {
				int raw_ret = ges_video_transition_get_border(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("border", val);
				val.Dispose ();
			}
		}

		[Obsolete]
		[GLib.Property ("invert")]
		public bool Invert {
			get {
				GLib.Value val = GetProperty ("invert");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("invert", val);
				val.Dispose ();
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_video_transition_get_transition_type(IntPtr raw);

		[GLib.Property ("transition-type")]
		public GES.VideoStandardTransitionType TransitionType {
			get  {
				int raw_ret = ges_video_transition_get_transition_type(Handle);
				GES.VideoStandardTransitionType ret = (GES.VideoStandardTransitionType) raw_ret;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("transition-type", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_ges_reserved"
							, GES.Transition.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_video_transition_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_video_transition_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_video_transition_is_inverted(IntPtr raw);

		[Obsolete]
		public bool IsInverted { 
			get {
				bool raw_ret = ges_video_transition_is_inverted(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_video_transition_set_inverted(IntPtr raw, bool inverted);

		[Obsolete]
		public bool Inverted { 
			set {
				ges_video_transition_set_inverted(Handle, value);
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_video_transition_set_transition_type(IntPtr raw, int type);

		public bool SetTransitionType(GES.VideoStandardTransitionType type) {
			bool raw_ret = ges_video_transition_set_transition_type(Handle, (int) type);
			bool ret = raw_ret;
			return ret;
		}


		static VideoTransition ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GES.Transition.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}