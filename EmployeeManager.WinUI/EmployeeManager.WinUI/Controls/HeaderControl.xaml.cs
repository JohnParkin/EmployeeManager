﻿using EmployeeManager.Common.Model;
using EmployeeManager.ViewModel;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using EmployeeManager.Common.Services;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace EmployeeManager.WinUI.Controls
{
    public sealed partial class HeaderControl : UserControl
    {
        BlobUpload blobUpload = new BlobUpload();

        public HeaderControl()
        {
            this.InitializeComponent();
        }

        public void UpLoad()
        {
            blobUpload.UploadFileToBlobStorage();
        }
    }
}
