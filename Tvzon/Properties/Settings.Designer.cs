﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tvzon.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\ProgramData\\DVBLogic\\DVBLink\\xmltv\\tvzon.xml")]
        public string OutputPath {
            get {
                return ((string)(this["OutputPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::SerializableStringDictionary ImageCache {
            get {
                return ((global::SerializableStringDictionary)(this["ImageCache"]));
            }
            set {
                this["ImageCache"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("14")]
        public int DaysInHistory {
            get {
                return ((int)(this["DaysInHistory"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WriteToLog {
            get {
                return ((bool)(this["WriteToLog"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int PreviousShownDuration {
            get {
                return ((int)(this["PreviousShownDuration"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool InsertEpisodeInDesc {
            get {
                return ((bool)(this["InsertEpisodeInDesc"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://xmltv.xmltv.se/channels-Sweden.xml.gz")]
        public string ChannelsUrl {
            get {
                return ((string)(this["ChannelsUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://xmltv.xmltv.se/datalist.xml.gz")]
        public string ChannelsLastModifiedUrl {
            get {
                return ((string)(this["ChannelsLastModifiedUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://xmltv.xmltv.se/{0}_{1:yyyy-MM-dd}.xml.gz")]
        public string ChannelUrl {
            get {
                return ((string)(this["ChannelUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>svt1hd.svt.se</string>
  <string>svt2hd.svt.se</string>
  <string>hd.tv3.se</string>
  <string>hd.tv4.se</string>
  <string>film.tv4.se</string>
  <string>news.tv4.se</string>
  <string>hd.kanal5.se</string>
  <string>tv6.se</string>
  <string>sjuan.se</string>
  <string>tv8.se</string>
  <string>kanal9.se</string>
  <string>discoverychannel.se</string>
  <string>disneychannel.se</string>
  <string>kunskapskanalen.svt.se</string>
  <string>svtb-svt24.svt.se</string>
  <string>emotion.cmore.se</string>
  <string>sf-kanalen.cmore.se</string>
  <string>first.cmore.se</string>
  <string>series.cmore.se</string>
  <string>hitshd.cmore.se</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Channels {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Channels"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int Days {
            get {
                return ((int)(this["Days"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"
					{
					channels: [
						{
							channelId: ""hitshd.cmore.se"",
							monday: { start: ""07:00"", end:""16:30""},
							tuesday: { start: ""00:30"", end:""16:30""},
							wednesday: { start: ""00:30"", end:""16:30""},
							thursday: { start: ""00:30"", end:""16:30""},
							friday: { start: ""00:30"", end:""23:59""},
							saturday: { start: ""00:00"", end:""07:00""},
							sunday: { start: ""00:00"", end:""00:00""}
						},
						{
							channelId: ""emotion.cmore.se"",
							monday: { start: ""01:00"", end:""18:30""},
							tuesday: { start: ""01:00"", end:""18:30""},
							wednesday: { start: ""01:00"", end:""18:30""},
							thursday: { start: ""01:00"", end:""18:30""},
							friday: { start: ""01:00"", end:""18:30""},
							saturday: { start: ""00:00"", end:""00:00""},
							sunday: { start: ""00:00"", end:""00:00""}
						},
						{
							channelId: ""sf-kanalen.cmore.se"",
							monday: { start: ""01:00"", end:""18:00""},
							tuesday: { start: ""01:00"", end:""18:00""},
							wednesday: { start: ""01:00"", end:""18:00""},
							thursday: { start: ""01:00"", end:""18:00""},
							friday: { start: ""01:00"", end:""18:00""},
							saturday: { start: ""01:00"", end:""12:00""},
							sunday: { start: ""01:00"", end:""12:00""}
						}
					]
					}
				")]
        public string ChannelSettings {
            get {
                return ((string)(this["ChannelSettings"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\n     <SerializableStringDictionary>\r\n      <ArrayOfAnyType xmlns:xsi=\"http://ww" +
            "w.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r" +
            "\n       <anyType xsi:type=\"Node\">\r\n        <key>tnt-tv.se</key>\r\n        <val>tv" +
            "7</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>kanal" +
            "5.se</key>\r\n        <val>kanal5</val>\r\n       </anyType>\r\n       <anyType xsi:ty" +
            "pe=\"Node\">\r\n        <key>first.cmore.se</key>\r\n        <val>c-more-first</val>\r\n" +
            "       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>star.nonstop.t" +
            "v</key>\r\n        <val>star!</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"" +
            "Node\">\r\n        <key>kanalglobal.se</key>\r\n        <val>kanalglobal</val>\r\n     " +
            "  </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>kunskapskanalen.svt" +
            ".se</key>\r\n        <val>kunskapskanalen</val>\r\n       </anyType>\r\n       <anyTyp" +
            "e xsi:type=\"Node\">\r\n        <key>svtb-svt24.svt.se</key>\r\n        <val>barnkanal" +
            "en</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>nick" +
            "elodeon.se</key>\r\n        <val>nickelodeon</val>\r\n       </anyType>\r\n       <any" +
            "Type xsi:type=\"Node\">\r\n        <key>disneychannel.se</key>\r\n        <val>disneyc" +
            "hannel</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>" +
            "kanal9.se</key>\r\n        <val>kanal9</val>\r\n       </anyType>\r\n       <anyType x" +
            "si:type=\"Node\">\r\n        <key>tv10.se</key>\r\n        <val>tv10</val>\r\n       </a" +
            "nyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>hitshd.cmore.se</key>\r\n " +
            "       <val>c-more-hits-hd</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"N" +
            "ode\">\r\n        <key>showtime.nonstop.tv</key>\r\n        <val>showtime</val>\r\n    " +
            "   </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>tv6.se</key>\r\n    " +
            "    <val>tv6</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n       " +
            " <key>tv8.se</key>\r\n        <val>tv8</val>\r\n       </anyType>\r\n       <anyType x" +
            "si:type=\"Node\">\r\n        <key>film.tv4.se</key>\r\n        <val>tv4film</val>\r\n   " +
            "    </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>cartoonnetwork.se" +
            "</key>\r\n        <val>cartoonnetwork</val>\r\n       </anyType>\r\n       <anyType xs" +
            "i:type=\"Node\">\r\n        <key>hd.mtv.se</key>\r\n        <val>mtvn-hd</val>\r\n      " +
            " </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>sjuan.se</key>\r\n    " +
            "    <val>sjuan</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n     " +
            "   <key>hd.tv4.se</key>\r\n        <val>tv4hd</val>\r\n       </anyType>\r\n       <an" +
            "yType xsi:type=\"Node\">\r\n        <key>tv11.tv4.se</key>\r\n        <val>tv11</val>\r" +
            "\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>svt1hd.svt.se" +
            "</key>\r\n        <val>svt1hd</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"" +
            "Node\">\r\n        <key>silver.nonstop.tv</key>\r\n        <val>silver</val>\r\n       " +
            "</anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>xd.disneychannel.se</" +
            "key>\r\n        <val>disneyxd</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"" +
            "Node\">\r\n        <key>animalplanet.se</key>\r\n        <val>animalplanet</val>\r\n   " +
            "    </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>discoverychannel." +
            "se</key>\r\n        <val>discovery</val>\r\n       </anyType>\r\n       <anyType xsi:t" +
            "ype=\"Node\">\r\n        <key>emotion.cmore.se</key>\r\n        <val>c-more-emotion</v" +
            "al>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>tcmeurope" +
            ".com</key>\r\n        <val>tcm</val>\r\n       </anyType>\r\n       <anyType xsi:type=" +
            "\"Node\">\r\n        <key>bbcworldnews.com</key>\r\n        <val>bbcworld</val>\r\n     " +
            "  </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>mtv.se</key>\r\n     " +
            "   <val>mtv</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        " +
            "<key>sport.tv4.se</key>\r\n        <val>tv4sport</val>\r\n       </anyType>\r\n       " +
            "<anyType xsi:type=\"Node\">\r\n        <key>axess.se</key>\r\n        <val>axesstv</va" +
            "l>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>sf-kanalen" +
            ".cmore.se</key>\r\n        <val>sf-kanalen</val>\r\n       </anyType>\r\n       <anyTy" +
            "pe xsi:type=\"Node\">\r\n        <key>eurosport2.se</key>\r\n        <val>eurosport2</" +
            "val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>cnn.com<" +
            "/key>\r\n        <val>cnn</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node" +
            "\">\r\n        <key>hd.tv3.se</key>\r\n        <val>tv3hd</val>\r\n       </anyType>\r\n " +
            "      <anyType xsi:type=\"Node\">\r\n        <key>eurosport.se</key>\r\n        <val>e" +
            "urosport</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <ke" +
            "y>hd.kanal5.se</key>\r\n        <val>kanal5hd</val>\r\n       </anyType>\r\n       <an" +
            "yType xsi:type=\"Node\">\r\n        <key>hd.natgeo.se</key>\r\n        <val>nationalge" +
            "ographichd</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <" +
            "key>svt2.svt.se</key>\r\n        <val>svt2</val>\r\n       </anyType>\r\n       <anyTy" +
            "pe xsi:type=\"Node\">\r\n        <key>science.discoverychannel.com</key>\r\n        <v" +
            "al>discoveryscience</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n" +
            "        <key>svt2hd.svt.se</key>\r\n        <val>svt2hd</val>\r\n       </anyType>\r\n" +
            "       <anyType xsi:type=\"Node\">\r\n        <key>tlcsverige.se</key>\r\n        <val" +
            ">tlc</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>co" +
            "medycentral.tv</key>\r\n        <val>comedycentral</val>\r\n       </anyType>\r\n     " +
            "  <anyType xsi:type=\"Node\">\r\n        <key>tv3.se</key>\r\n        <val>tv3</val>\r\n" +
            "       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>tv4.se</key>\r\n" +
            "        <val>tv4</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n   " +
            "     <key>svt1.svt.se</key>\r\n        <val>svt1</val>\r\n       </anyType>\r\n       " +
            "<anyType xsi:type=\"Node\">\r\n        <key>fakta.tv4.se</key>\r\n        <val>tv4fakt" +
            "a</val>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>serie" +
            "s.cmore.se</key>\r\n        <val>c-more-series</val>\r\n       </anyType>\r\n       <a" +
            "nyType xsi:type=\"Node\">\r\n        <key>news.tv4.se</key>\r\n        <val>tv4news</v" +
            "al>\r\n       </anyType>\r\n       <anyType xsi:type=\"Node\">\r\n        <key>travelcha" +
            "nneltv.se</key>\r\n        <val>travel</val>\r\n       </anyType>\r\n       <anyType x" +
            "si:type=\"Node\">\r\n        <key>vh1.se</key>\r\n        <val>vh1</val>\r\n       </any" +
            "Type>\r\n      </ArrayOfAnyType>\r\n     </SerializableStringDictionary>\r\n    ")]
        public global::SerializableStringDictionary TvNuMappings {
            get {
                return ((global::SerializableStringDictionary)(this["TvNuMappings"]));
            }
        }
    }
}
