//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("ReactiveUIDemo.Pages.ValidationDemoPage.xaml", "Pages/ValidationDemoPage.xaml", typeof(global::ReactiveUIDemo.Pages.ValidationDemoPage))]

namespace ReactiveUIDemo.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\ValidationDemoPage.xaml")]
    public partial class ValidationDemoPage : global::ReactiveUI.XamForms.ReactiveContentPage<global::ReactiveUIDemo.ViewModels.ValidationDemoViewModel> {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label validationLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ValidationDemoPage));
            validationLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "validationLabel");
        }
    }
}
