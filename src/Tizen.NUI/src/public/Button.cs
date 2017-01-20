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

using System;
using System.Runtime.InteropServices;


public class Button : View {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Button(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Button_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Button obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Button() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_Button(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



  private EventHandlerWithReturnType<object,EventArgs,bool> _clickedEventHandler;
  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate bool ClickedCallbackType(global::System.IntPtr data);
  private ClickedCallbackType _clickedCallback;

  public event EventHandlerWithReturnType<object,EventArgs,bool> Clicked
  {
     add
     {
       // Restricted to only one listener
       if (_clickedEventHandler == null)
       {
         _clickedCallback = new ClickedCallbackType(OnClicked);
         this.ClickedSignal().Connect(_clickedCallback);
       }

       _clickedEventHandler += value;
     }

     remove
     {
       if (_clickedEventHandler != null)
       {
         this.ClickedSignal().Disconnect(_clickedCallback);
       }

       _clickedEventHandler -= value;
     }
  }

  // Callback for button click signal
  private bool OnClicked (IntPtr data)
  {

    if (_clickedEventHandler != null)
    {
      //here we send all data to user event handlers
      return _clickedEventHandler(this, null);
    }
    return false;
  }



  private EventHandlerWithReturnType<object,EventArgs,bool> _pressedEventHandler;
  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate bool PressedCallbackType(global::System.IntPtr data);
  private PressedCallbackType _pressedCallback;

  public event EventHandlerWithReturnType<object,EventArgs,bool> Pressed
  {
     add
     {
       // Restricted to only one listener
       if (_pressedEventHandler == null)
       {
          _pressedCallback = new PressedCallbackType(OnPressed);
          this.PressedSignal().Connect(_pressedCallback);
       }

       _pressedEventHandler += value;
     }

     remove
     {
       if (_pressedEventHandler != null)
       {
           this.PressedSignal().Disconnect(_pressedCallback);
       }

       _pressedEventHandler -= value;
     }
  }

  // Callback for button click signal
  private bool OnPressed (IntPtr data)
  {
     if (_pressedEventHandler != null)
     {
        //here we send all data to user event handlers
       return _pressedEventHandler(this, null);
     }
     return false;
  }



  private EventHandlerWithReturnType<object,EventArgs,bool>  _releasedEventHandler;
  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate bool ReleasedCallbackType(global::System.IntPtr data);
  private ReleasedCallbackType _releasedCallback;

  public event EventHandlerWithReturnType<object,EventArgs,bool> Released
  {
     add
     {
       // Restricted to only one listener
       if (_releasedEventHandler == null)
       {
          _releasedCallback = new ReleasedCallbackType(OnReleased);
          this.ReleasedSignal().Connect(_releasedCallback);
       }

       _releasedEventHandler += value;
     }

     remove
     {
        lock(this)
        {
           if (_releasedEventHandler != null)
           {
               this.ReleasedSignal().Disconnect(_releasedCallback);
           }

           _releasedEventHandler -= value;
        }
     }
  }

  // Callback for button click signal
  private bool OnReleased (IntPtr data)
  {
     if (_releasedEventHandler != null)
     {
        //here we send all data to user event handlers
       return _releasedEventHandler(this, null);
     }
     return false;
  }


  private EventHandlerWithReturnType<object,EventArgs,bool> _stateChangedEventHandler;
  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate bool StateChangedCallback(global::System.IntPtr data);
  private StateChangedCallback _stateChangedCallback;

  public event EventHandlerWithReturnType<object,EventArgs,bool> StateChanged
  {
     add
     {
       // Restricted to only one listener
       if (_stateChangedEventHandler == null)
       {
          _stateChangedCallback = new StateChangedCallback(OnStateChanged);
          this.StateChangedSignal().Connect(_stateChangedCallback);
       }

       _stateChangedEventHandler += value;
     }

     remove
     {
       if (_stateChangedEventHandler != null)
       {
           this.StateChangedSignal().Disconnect(_stateChangedCallback);
       }

       _stateChangedEventHandler -= value;
     }
  }

  // Callback for button click signal
  private bool OnStateChanged (IntPtr data)
  {
     if (_stateChangedEventHandler != null)
     {
        //here we send all data to user event handlers
       return _stateChangedEventHandler(this, null);
     }
     return false;
  }

 public static Button GetButtonFromPtr(global::System.IntPtr cPtr) {
    Button ret = new Button(cPtr, false);
   if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }


  public class Property : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Property() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_Button_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_Button_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int DISABLED = NDalicPINVOKE.Button_Property_DISABLED_get();
    public static readonly int AUTO_REPEATING = NDalicPINVOKE.Button_Property_AUTO_REPEATING_get();
    public static readonly int INITIAL_AUTO_REPEATING_DELAY = NDalicPINVOKE.Button_Property_INITIAL_AUTO_REPEATING_DELAY_get();
    public static readonly int NEXT_AUTO_REPEATING_DELAY = NDalicPINVOKE.Button_Property_NEXT_AUTO_REPEATING_DELAY_get();
    public static readonly int TOGGLABLE = NDalicPINVOKE.Button_Property_TOGGLABLE_get();
    public static readonly int SELECTED = NDalicPINVOKE.Button_Property_SELECTED_get();
    public static readonly int UNSELECTED_STATE_IMAGE = NDalicPINVOKE.Button_Property_UNSELECTED_STATE_IMAGE_get();
    public static readonly int SELECTED_STATE_IMAGE = NDalicPINVOKE.Button_Property_SELECTED_STATE_IMAGE_get();
    public static readonly int DISABLED_STATE_IMAGE = NDalicPINVOKE.Button_Property_DISABLED_STATE_IMAGE_get();
    public static readonly int UNSELECTED_COLOR = NDalicPINVOKE.Button_Property_UNSELECTED_COLOR_get();
    public static readonly int SELECTED_COLOR = NDalicPINVOKE.Button_Property_SELECTED_COLOR_get();
    public static readonly int LABEL = NDalicPINVOKE.Button_Property_LABEL_get();
    public static readonly int LABEL_TEXT = NDalicPINVOKE.Button_Property_LABEL_TEXT_get();
  
  }

  public Button() : this(NDalicPINVOKE.new_Button__SWIG_0(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Button(Button button) : this(NDalicPINVOKE.new_Button__SWIG_1(Button.getCPtr(button)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Button Assign(Button button) {
    Button ret = new Button(NDalicPINVOKE.Button_Assign(swigCPtr, Button.getCPtr(button)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static Button DownCast(BaseHandle handle) {
    Button ret = new Button(NDalicPINVOKE.Button_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsDisabled() {
    bool ret = NDalicPINVOKE.Button_IsDisabled(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsAutoRepeating() {
    bool ret = NDalicPINVOKE.Button_IsAutoRepeating(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetInitialAutoRepeatingDelay() {
    float ret = NDalicPINVOKE.Button_GetInitialAutoRepeatingDelay(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetNextAutoRepeatingDelay() {
    float ret = NDalicPINVOKE.Button_GetNextAutoRepeatingDelay(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsTogglableButton() {
    bool ret = NDalicPINVOKE.Button_IsTogglableButton(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsSelected() {
    bool ret = NDalicPINVOKE.Button_IsSelected(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetAnimationTime() {
    float ret = NDalicPINVOKE.Button_GetAnimationTime(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetLabelText() {
    string ret = NDalicPINVOKE.Button_GetLabelText(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLabel(Actor label) {
    NDalicPINVOKE.Button_SetLabel(swigCPtr, Actor.getCPtr(label));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetButtonImage(Image image) {
    NDalicPINVOKE.Button_SetButtonImage(swigCPtr, Image.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSelectedImage(Image image) {
    NDalicPINVOKE.Button_SetSelectedImage(swigCPtr, Image.getCPtr(image));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Actor GetButtonImage() {
    Actor ret = new Actor(NDalicPINVOKE.Button_GetButtonImage(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Actor GetSelectedImage() {
    Actor ret = new Actor(NDalicPINVOKE.Button_GetSelectedImage(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ButtonSignal PressedSignal() {
    ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_PressedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ButtonSignal ReleasedSignal() {
    ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_ReleasedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ButtonSignal ClickedSignal() {
    ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_ClickedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ButtonSignal StateChangedSignal() {
    ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_StateChangedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum PropertyRange {
    PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
    PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX+1000
  }

  public bool Disabled
  {
    get
    {
      bool temp = false;
      GetProperty( Button.Property.DISABLED).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.DISABLED, new NUI.Property.Value( value ) );
    }
  }
  public bool AutoRepeating
  {
    get
    {
      bool temp = false;
      GetProperty( Button.Property.AUTO_REPEATING).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.AUTO_REPEATING, new NUI.Property.Value( value ) );
    }
  }
  public float InitialAutoRepeatingDelay
  {
    get
    {
      float temp = 0.0f;
      GetProperty( Button.Property.INITIAL_AUTO_REPEATING_DELAY).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.INITIAL_AUTO_REPEATING_DELAY, new NUI.Property.Value( value ) );
    }
  }
  public float NextAutoRepeatingDelay
  {
    get
    {
      float temp = 0.0f;
      GetProperty( Button.Property.NEXT_AUTO_REPEATING_DELAY).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.NEXT_AUTO_REPEATING_DELAY, new NUI.Property.Value( value ) );
    }
  }
  public bool Togglable
  {
    get
    {
      bool temp = false;
      GetProperty( Button.Property.TOGGLABLE).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.TOGGLABLE, new NUI.Property.Value( value ) );
    }
  }
  public bool Selected
  {
    get
    {
      bool temp = false;
      GetProperty( Button.Property.SELECTED).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.SELECTED, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map UnselectedStateImage
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Button.Property.UNSELECTED_STATE_IMAGE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.UNSELECTED_STATE_IMAGE, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map SelectedStateImage
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Button.Property.SELECTED_STATE_IMAGE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.SELECTED_STATE_IMAGE, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map DisabledStateImage
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Button.Property.DISABLED_STATE_IMAGE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.DISABLED_STATE_IMAGE, new NUI.Property.Value( value ) );
    }
  }
  public Vector4 UnselectedColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( Button.Property.UNSELECTED_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.UNSELECTED_COLOR, new NUI.Property.Value( value ) );
    }
  }
  public Vector4 SelectedColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( Button.Property.SELECTED_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.SELECTED_COLOR, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map Label
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Button.Property.LABEL).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.LABEL, new NUI.Property.Value( value ) );
    }
  }
  public string LabelText
  {
    get
    {
      string temp;
      GetProperty( Button.Property.LABEL_TEXT).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( Button.Property.LABEL_TEXT, new NUI.Property.Value( value ) );
    }
  }

}

}