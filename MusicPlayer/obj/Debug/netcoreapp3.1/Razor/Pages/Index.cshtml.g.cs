#pragma checksum "E:\dev\git\ASP-NET-Core_Web_Music_Player\MusicPlayer\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d289c22fbe02ab4e6b881ad54827cfa8ca2de57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicPlayer.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MusicPlayer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\dev\git\ASP-NET-Core_Web_Music_Player\MusicPlayer\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\dev\git\ASP-NET-Core_Web_Music_Player\MusicPlayer\Pages\_ViewImports.cshtml"
using MusicPlayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\dev\git\ASP-NET-Core_Web_Music_Player\MusicPlayer\Pages\_ViewImports.cshtml"
using MusicPlayer.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d289c22fbe02ab4e6b881ad54827cfa8ca2de57", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231d691469318d7cbea94b501ab2664d9779204d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\dev\git\ASP-NET-Core_Web_Music_Player\MusicPlayer\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""fullMaster text-light"">
    <div style=""height: 100%;"">
        <div class=""backgroundGradient"">
            <div class=""backgroundGradient__buffer backgroundGradient__hidden""></div>
            <div class=""backgroundGradient__buffer bg-dark""></div>
            <div class=""backgroundGradient__imageOverlay""></div>
        </div>
    </div>
    <div class=""fullMaster__foreground"">
        <div class=""fullMaster__artwork"">
            <div class=""image m-sound image__lightOutline readOnly customImage interactive sc-artwork sc-artwork-placeholder-10 m-loaded"" tabindex=""0"" style=""height: 100%; width: 100%;"">
                <span style=""background-image: url(https://static.fnac-static.com/multimedia/FR/Images_Produits/FR/fnac.com/Visual_Principal_340/8/5/7/0600753012758/tsp20120923065845/Generation-zouk.jpg); width: 100%; height: 100%; opacity: 1;"" class=""sc-artwork sc-artwork-placeholder-10  image__full g-opacity-transition"" aria-label=""Woah"" aria-role=""img""></span>
            </div>
 ");
            WriteLiteral(@"       </div>
        <div class=""fullMaster__title"">
            <div class=""soundTitle__playButton"">
                <a role=""button"" onclick=""wavesurfer.playPause()"" style=""cursor: pointer;"">
                    <span style=""font-size: 3rem; color: #14ad0c;"">
                        <i class=""fas fa-play-circle""></i>
                    </span>
                </a>
            </div>
            <div class=""soundTitle__nameContainer"">
                <div class=""soundTitle__creator"">
                    Johnny le Dep
                </div>
                <div class=""soundTitle__title"">
                    Génération Zouk !
                </div>
            </div>
        </div>
        <div class=""fullMaster__info"">
            <span style=""font-size: 1.8rem;"">
                <a role=""button"" onclick=""wavesurfer.toggleMute()"" style=""cursor: pointer;"">
                    <i class=""fas fa-volume-mute""></i>
                </a>
                <input id=""volume"" type=""range"" min=""0""");
            WriteLiteral(@" max=""1"" value=""1"" step=""0.05"">
            </span>
        </div>
        <div class=""fullMaster__playerArea"">
            <div class=""fullMaster__waveform"">
                <div class=""waveformWrapper"">
                    <div id=""waveform"">
                        <div class=""timeIdicators"" id=""current"">0:00</div>
                        <div class=""timeIdicators"" id=""duration"">0:00</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Coreset</a>.</p>

<script>
    // Set-up for wavesurfer
    var wavesurfer = WaveSurfer.create({
        container: document.querySelector('#waveform'),
        waveColor: 'White',
        progressColor: '#14ad0c',
        barWidth: 2,
        cursorWidth: 0,
        responsive: true
    });

    wavesurfer.setVolume(0.4);
    document.querySelector('#volume').value = 0.4;

    var volumeInput =");
            WriteLiteral(@" document.querySelector('#volume');
    var onChangeVolume = function (e) {
        wavesurfer.setVolume(e.target.value);
        console.log(e.target.value);
    };

    volumeInput.addEventListener('input', onChangeVolume);
    volumeInput.addEventListener('change', onChangeVolume);

    // Loading audio file
    wavesurfer.load('audio/bell.mp3');

    // Take a float value of time return to the 'm:ss' format
    var formatTime = function (timeValue) {
        return Math.trunc(timeValue / 60) + ':' + ('0' + Math.trunc(timeValue % 60)).slice(-2)
    }

    // Update current sound duration
    wavesurfer.on('ready', function () {
        document.getElementById(""duration"").innerHTML = formatTime(wavesurfer.getDuration())
    });

    // Update current sound cursor
    wavesurfer.on('audioprocess', function () {
        document.getElementById(""current"").innerHTML = formatTime(wavesurfer.getCurrentTime())
    });
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
