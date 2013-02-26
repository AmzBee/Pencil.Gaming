using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    public static class Glfw64 {
        [DllImport("glfw64")]
        internal static extern int glfwInit();
        [DllImport("glfw64")]
        internal static extern void glfwTerminate();
        [DllImport("glfw64")]
        internal static extern void glfwGetVersion(out int major, out int minor, out int rev);

        [DllImport("glfw64")]
        internal static extern int glfwOpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, int mode);
        [DllImport("glfw64")]
        internal static extern void glfwOpenWindowHint(int target, int hint);
        [DllImport("glfw64")]
        internal static extern void glfwCloseWindow();
        [DllImport("glfw64")]
        internal static extern void glfwSetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);
        [DllImport("glfw64")]
        internal static extern void glfwGetWindowSize(out int width, out int height);
        [DllImport("glfw64")]
        internal static extern void glfwSetWindowSize(int width, int height);
        [DllImport("glfw64")]
        internal static extern void glfwSetWindowPos(int x, int y);
        [DllImport("glfw64")]
        internal static extern void glfwIconifyWindow();
        [DllImport("glfw64")]
        internal static extern void glfwRestoreWindow();
        [DllImport("glfw64")]
        internal static extern void glfwSwapBuffers();
        [DllImport("glfw64")]
        internal static extern void glfwSwapInterval(int interval);
        [DllImport("glfw64")]
        internal static extern int glfwGetWindowParam(int param);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetWindowSizeCallback(/*GLFWwindowsizefun*/IntPtr cbfun);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetWindowCloseCallback(/*GLFWwindowclosefun*/IntPtr cbfun);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetWindowRefreshCallback(/*GLFWwindowrefreshfun*/IntPtr cbfun);

        [DllImport("glfw64")]
        internal static extern int glfwGetVideoModes([MarshalAs(UnmanagedType.LPArray)] GlfwVidMode[] list, int maxcount);
        [DllImport("glfw64")]
        internal static extern void glfwGetDesktopMode(out GlfwVidMode mode);

        [DllImport("glfw64")]
        internal static extern void glfwPollEvents();
        [DllImport("glfw64")]
        internal static extern void glfwWaitEvents();
        [DllImport("glfw64")]
        internal static extern int glfwGetKey(int key);
        [DllImport("glfw64")]
        internal static extern int glfwGetMouseButton(int button);
        [DllImport("glfw64")]
        internal static extern void glfwGetMousePos(out int xpos, out int ypos);
        [DllImport("glfw64")]
        internal static extern void glfwSetMousePos(int xpos, int ypos);
        [DllImport("glfw64")]
        internal static extern int glfwGetMouseWheel();
        [DllImport("glfw64")]
        internal static extern void glfwSetMouseWheel(int pos);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetKeyCallback(/*GLFWkeyfun*/IntPtr cbfun);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetCharCallback(/*GLFWcharfun*/IntPtr cbfun);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetMouseButtonCallback(/*GLFWmousebuttonfun*/IntPtr cbfun);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetMousePosCallback(/*GLFWmouseposfun*/IntPtr cbfun);
        //[DllImport("glfw64")]
        //internal static extern void glfwSetMouseWheelCallback(/*GLFWmousewheelfun*/IntPtr cbfun);

        [DllImport("glfw64")]
        internal static extern int glfwGetJoystickParam(int joy, int param);
        [DllImport("glfw64")]
        internal static extern int glfwGetJoystickPos(int joy, [MarshalAs(UnmanagedType.LPArray)] float[] pos, int numaxes);
        [DllImport("glfw64")]
        internal static extern int glfwGetJoystickButtons(int joy, [MarshalAs(UnmanagedType.LPArray)] byte[] buttons, int numbuttons);

        [DllImport("glfw64")]
        internal static extern double glfwGetTime();
        [DllImport("glfw64")]
        internal static extern void glfwSetTime(double time);
        [DllImport("glfw64")]
        internal static extern void glfwSleep(double time);

        [DllImport("glfw64")]
        internal static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
        [DllImport("glfw64")]
        internal static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
        [DllImport("glfw64")]
        internal static extern void glfwGetGLVersion(out int major, out int minor, out int rev);

        //[DllImport("glfw64")]
        //internal static extern /*GLFWthread*/IntPtr glfwCreateThread(/*GLFWthreadfun*/IntPtr fun, IntPtr arg);
        //[DllImport("glfw64")]
        //internal static extern void glfwDestroyThread(/*GLFWthread*/IntPtr ID);
        //[DllImport("glfw64")]
        //internal static extern int glfwWaitThread(/*GLFWthread*/IntPtr ID, int waitmode);
        //[DllImport("glfw64")]
        //internal static extern /*GLFWthread*/IntPtr glfwGetThreadID();
        //[DllImport("glfw64")]
        //internal static extern /*GLFWmutex*/IntPtr glfwCreateMutex();
        //[DllImport("glfw64")]
        //internal static extern void glfwDestroyMutex(/*GLFWmutex*/IntPtr mutex);
        //[DllImport("glfw64")]
        //internal static extern void glfwLockMutex(/*GLFWmutex*/IntPtr mutex);
        //[DllImport("glfw64")]
        //internal static extern void glfwUnlockMutex(/*GLFWmutex*/IntPtr mutex);
        //[DllImport("glfw64")]
        //internal static extern /*GLFWcond*/IntPtr glfwCreateCond();
        //[DllImport("glfw64")]
        //internal static extern void glfwDestroyCond(/*GLFWcond*/IntPtr cond);
        //[DllImport("glfw64")]
        //internal static extern void glfwWaitCond(/*GLFWcond*/IntPtr cond, /*GLFWmutex*/IntPtr mutex, double timeout);
        //[DllImport("glfw64")]
        //internal static extern void glfwSignalCond(/*GLFWcond*/IntPtr cond);
        //[DllImport("glfw64")]
        //internal static extern void glfwBroadcastCond(/*GLFWcond*/IntPtr cond);
        [DllImport("glfw64")]
        internal static extern int glfwGetNumberOfProcessors();

        [DllImport("glfw64")]
        internal static extern void glfwEnable(int token);
        [DllImport("glfw64")]
        internal static extern void glfwDisable(int token);

        [DllImport("glfw64")]
        internal static extern int glfwReadImage([MarshalAs(UnmanagedType.LPStr)] string name, out GlfwImage img, int flags);
        [DllImport("glfw64")]
        internal static extern int glfwReadMemoryImage(IntPtr data, long size, ref GlfwImage img, int flags);
        [DllImport("glfw64")]
        internal static extern void glfwFreeImage(ref GlfwImage img);
        [DllImport("glfw64")]
        internal static extern int glfwLoadTexture2D([MarshalAs(UnmanagedType.LPStr)] string name, int flags);
        [DllImport("glfw64")]
        internal static extern int glfwLoadMemoryTexture2D(IntPtr data, long size, int flags);
        [DllImport("glfw64")]
        internal static extern int glfwLoadTextureImage2D(ref GlfwImage img, int flags);
    }
}

