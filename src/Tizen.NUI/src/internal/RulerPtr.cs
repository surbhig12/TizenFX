//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NUI {

public class RulerPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RulerPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RulerPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RulerPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_RulerPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RulerPtr() : this(NDalicPINVOKE.new_RulerPtr__SWIG_0(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public RulerPtr(Ruler p) : this(NDalicPINVOKE.new_RulerPtr__SWIG_1(Ruler.getCPtr(p)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public RulerPtr(RulerPtr rhs) : this(NDalicPINVOKE.new_RulerPtr__SWIG_2(RulerPtr.getCPtr(rhs)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Ruler Get() {
    global::System.IntPtr cPtr = NDalicPINVOKE.RulerPtr_Get(swigCPtr);
    Ruler ret = (cPtr == global::System.IntPtr.Zero) ? null : new Ruler(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Ruler __deref__() {
    global::System.IntPtr cPtr = NDalicPINVOKE.RulerPtr___deref__(swigCPtr);
    Ruler ret = (cPtr == global::System.IntPtr.Zero) ? null : new Ruler(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Ruler __ref__() {
    Ruler ret = new Ruler(NDalicPINVOKE.RulerPtr___ref__(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RulerPtr Assign(RulerPtr rhs) {
    RulerPtr ret = new RulerPtr(NDalicPINVOKE.RulerPtr_Assign__SWIG_0(swigCPtr, RulerPtr.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RulerPtr Assign(Ruler rhs) {
    RulerPtr ret = new RulerPtr(NDalicPINVOKE.RulerPtr_Assign__SWIG_1(swigCPtr, Ruler.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset() {
    NDalicPINVOKE.RulerPtr_Reset__SWIG_0(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reset(Ruler rhs) {
    NDalicPINVOKE.RulerPtr_Reset__SWIG_1(swigCPtr, Ruler.getCPtr(rhs));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Ruler Detach() {
    global::System.IntPtr cPtr = NDalicPINVOKE.RulerPtr_Detach(swigCPtr);
    Ruler ret = (cPtr == global::System.IntPtr.Zero) ? null : new Ruler(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Snap(float x, float bias) {
    float ret = NDalicPINVOKE.RulerPtr_Snap__SWIG_0(swigCPtr, x, bias);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Snap(float x) {
    float ret = NDalicPINVOKE.RulerPtr_Snap__SWIG_1(swigCPtr, x);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetPositionFromPage(uint page, out uint volume, bool wrap) {
    float ret = NDalicPINVOKE.RulerPtr_GetPositionFromPage(swigCPtr, page, out volume, wrap);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetPageFromPosition(float position, bool wrap) {
    uint ret = NDalicPINVOKE.RulerPtr_GetPageFromPosition(swigCPtr, position, wrap);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetTotalPages() {
    uint ret = NDalicPINVOKE.RulerPtr_GetTotalPages(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Ruler.RulerType GetType() {
    Ruler.RulerType ret = (Ruler.RulerType)NDalicPINVOKE.RulerPtr_GetType(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEnabled() {
    bool ret = NDalicPINVOKE.RulerPtr_IsEnabled(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Enable() {
    NDalicPINVOKE.RulerPtr_Enable(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Disable() {
    NDalicPINVOKE.RulerPtr_Disable(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDomain(RulerDomain domain) {
    NDalicPINVOKE.RulerPtr_SetDomain(swigCPtr, RulerDomain.getCPtr(domain));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public RulerDomain GetDomain() {
    RulerDomain ret = new RulerDomain(NDalicPINVOKE.RulerPtr_GetDomain(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DisableDomain() {
    NDalicPINVOKE.RulerPtr_DisableDomain(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public float Clamp(float x, float length, float scale) {
    float ret = NDalicPINVOKE.RulerPtr_Clamp__SWIG_0(swigCPtr, x, length, scale);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Clamp(float x, float length) {
    float ret = NDalicPINVOKE.RulerPtr_Clamp__SWIG_1(swigCPtr, x, length);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Clamp(float x) {
    float ret = NDalicPINVOKE.RulerPtr_Clamp__SWIG_2(swigCPtr, x);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Clamp(float x, float length, float scale, SWIGTYPE_p_Dali__Toolkit__ClampState clamped) {
    float ret = NDalicPINVOKE.RulerPtr_Clamp__SWIG_3(swigCPtr, x, length, scale, SWIGTYPE_p_Dali__Toolkit__ClampState.getCPtr(clamped));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float SnapAndClamp(float x, float bias, float length, float scale) {
    float ret = NDalicPINVOKE.RulerPtr_SnapAndClamp__SWIG_0(swigCPtr, x, bias, length, scale);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float SnapAndClamp(float x, float bias, float length) {
    float ret = NDalicPINVOKE.RulerPtr_SnapAndClamp__SWIG_1(swigCPtr, x, bias, length);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float SnapAndClamp(float x, float bias) {
    float ret = NDalicPINVOKE.RulerPtr_SnapAndClamp__SWIG_2(swigCPtr, x, bias);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float SnapAndClamp(float x) {
    float ret = NDalicPINVOKE.RulerPtr_SnapAndClamp__SWIG_3(swigCPtr, x);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float SnapAndClamp(float x, float bias, float length, float scale, SWIGTYPE_p_Dali__Toolkit__ClampState clamped) {
    float ret = NDalicPINVOKE.RulerPtr_SnapAndClamp__SWIG_4(swigCPtr, x, bias, length, scale, SWIGTYPE_p_Dali__Toolkit__ClampState.getCPtr(clamped));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reference() {
    NDalicPINVOKE.RulerPtr_Reference(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Unreference() {
    NDalicPINVOKE.RulerPtr_Unreference(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public int ReferenceCount() {
    int ret = NDalicPINVOKE.RulerPtr_ReferenceCount(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
