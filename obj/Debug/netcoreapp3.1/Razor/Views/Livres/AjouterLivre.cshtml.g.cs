#pragma checksum "/home/sebou/Documents/C#/MvcLibrary/Views/Livres/AjouterLivre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73391c8e9b59e04eb1d870eff9aeb6def56b68f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Livres_AjouterLivre), @"mvc.1.0.view", @"/Views/Livres/AjouterLivre.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73391c8e9b59e04eb1d870eff9aeb6def56b68f9", @"/Views/Livres/AjouterLivre.cshtml")]
    public class Views_Livres_AjouterLivre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/sebou/Documents/C#/MvcLibrary/Views/Livres/AjouterLivre.cshtml"
  
    ViewBag.Title = "Ajout de livre";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ajout de livre</h1>

<form action=""http://localhost:5000/Livres/ValiderAjouterLivre"" >
    <div class=""form-group"">
        <label for=""title"">Titre</label>
        <input type=""text""  class=""form-control"" id=""title"" name=""Title"" aria-describedby=""titreHelp"" placeholder=""Titre"">
    </div>
    <div class=""form-group"">
        <label for=""author"">Auteur</label>
        <input type=""text"" class=""form-control"" id=""author"" name=""Author"" aria-describedby=""auteurHelp"" placeholder=""Auteur"">
    </div>
     <div class=""form-group"">
        <label for=""year"">Année</label>
        <input type=""number"" class=""form-control"" id=""year"" name=""Year"" aria-describedby=""anneeHelp"" placeholder=""Annee"">
    </div>
     <div class=""form-group"">
        <label for=""price"">Prix</label>
        <input type=""number"" class=""form-control"" id=""price"" name =""Price"" aria-describedby=""prixHelp"" placeholder=""Prix"">
    </div>
    <button type=""submit"" class=""btn btn-primary"">Valider</button>
</form>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
