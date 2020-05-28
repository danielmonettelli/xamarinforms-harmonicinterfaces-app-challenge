using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]


#region FontIcons Embedded 
[assembly: ExportFont("monettelliuikitfonticons.ttf", Alias = "MonettelliFontIcons")]
#endregion

#region FontFamily Embedded 
[assembly: ExportFont("SourceSansPro-Bold.ttf", Alias = "SourceSansPro_Bold")]
[assembly: ExportFont("OpenSans-ExtraBold.ttf", Alias = "OpenSans_ExtraBold")]
[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "OpenSans_Bold")]
[assembly: ExportFont("OpenSans-SemiBold.ttf", Alias = "OpenSans_SemiBold")]
[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "OpenSans_Regular")]
#endregion