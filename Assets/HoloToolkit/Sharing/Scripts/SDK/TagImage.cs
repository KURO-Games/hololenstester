//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace HoloToolkit.Sharing {

public class TagImage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TagImage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TagImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TagImage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_TagImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual int GetWidth() {
    int ret = SharingClientPINVOKE.TagImage_GetWidth(swigCPtr);
    return ret;
  }

  public virtual int GetHeight() {
    int ret = SharingClientPINVOKE.TagImage_GetHeight(swigCPtr);
    return ret;
  }

  public virtual void CopyImageData(byte[] data, int bufferSize, int bytesPerPixel) {
    global::System.Runtime.InteropServices.GCHandle pinHandle_data = global::System.Runtime.InteropServices.GCHandle.Alloc(data, global::System.Runtime.InteropServices.GCHandleType.Pinned); try {
    {
      SharingClientPINVOKE.TagImage_CopyImageData(swigCPtr, (global::System.IntPtr)pinHandle_data.AddrOfPinnedObject(), bufferSize, bytesPerPixel);
    }
    } finally { pinHandle_data.Free(); }
  }

}

}
