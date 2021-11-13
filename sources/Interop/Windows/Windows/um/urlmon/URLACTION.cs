// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class URLACTION
    {
        [NativeTypeName("#define URLACTION_MIN 0x00001000")]
        public const int URLACTION_MIN = 0x00001000;

        [NativeTypeName("#define URLACTION_DOWNLOAD_MIN 0x00001000")]
        public const int URLACTION_DOWNLOAD_MIN = 0x00001000;

        [NativeTypeName("#define URLACTION_DOWNLOAD_SIGNED_ACTIVEX 0x00001001")]
        public const int URLACTION_DOWNLOAD_SIGNED_ACTIVEX = 0x00001001;

        [NativeTypeName("#define URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX 0x00001004")]
        public const int URLACTION_DOWNLOAD_UNSIGNED_ACTIVEX = 0x00001004;

        [NativeTypeName("#define URLACTION_DOWNLOAD_CURR_MAX 0x00001004")]
        public const int URLACTION_DOWNLOAD_CURR_MAX = 0x00001004;

        [NativeTypeName("#define URLACTION_DOWNLOAD_MAX 0x000011FF")]
        public const int URLACTION_DOWNLOAD_MAX = 0x000011FF;

        [NativeTypeName("#define URLACTION_ACTIVEX_MIN 0x00001200")]
        public const int URLACTION_ACTIVEX_MIN = 0x00001200;

        [NativeTypeName("#define URLACTION_ACTIVEX_RUN 0x00001200")]
        public const int URLACTION_ACTIVEX_RUN = 0x00001200;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY 0x00001201")]
        public const int URLACTION_ACTIVEX_OVERRIDE_OBJECT_SAFETY = 0x00001201;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY 0x00001202")]
        public const int URLACTION_ACTIVEX_OVERRIDE_DATA_SAFETY = 0x00001202;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY 0x00001203")]
        public const int URLACTION_ACTIVEX_OVERRIDE_SCRIPT_SAFETY = 0x00001203;

        [NativeTypeName("#define URLACTION_SCRIPT_OVERRIDE_SAFETY 0x00001401")]
        public const int URLACTION_SCRIPT_OVERRIDE_SAFETY = 0x00001401;

        [NativeTypeName("#define URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY 0x00001204")]
        public const int URLACTION_ACTIVEX_CONFIRM_NOOBJECTSAFETY = 0x00001204;

        [NativeTypeName("#define URLACTION_ACTIVEX_TREATASUNTRUSTED 0x00001205")]
        public const int URLACTION_ACTIVEX_TREATASUNTRUSTED = 0x00001205;

        [NativeTypeName("#define URLACTION_ACTIVEX_NO_WEBOC_SCRIPT 0x00001206")]
        public const int URLACTION_ACTIVEX_NO_WEBOC_SCRIPT = 0x00001206;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION 0x00001207")]
        public const int URLACTION_ACTIVEX_OVERRIDE_REPURPOSEDETECTION = 0x00001207;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_OPTIN 0x00001208")]
        public const int URLACTION_ACTIVEX_OVERRIDE_OPTIN = 0x00001208;

        [NativeTypeName("#define URLACTION_ACTIVEX_SCRIPTLET_RUN 0x00001209")]
        public const int URLACTION_ACTIVEX_SCRIPTLET_RUN = 0x00001209;

        [NativeTypeName("#define URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION 0x0000120A")]
        public const int URLACTION_ACTIVEX_DYNSRC_VIDEO_AND_ANIMATION = 0x0000120A;

        [NativeTypeName("#define URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST 0x0000120B")]
        public const int URLACTION_ACTIVEX_OVERRIDE_DOMAINLIST = 0x0000120B;

        [NativeTypeName("#define URLACTION_ACTIVEX_ALLOW_TDC 0x0000120C")]
        public const int URLACTION_ACTIVEX_ALLOW_TDC = 0x0000120C;

        [NativeTypeName("#define URLACTION_ACTIVEX_CURR_MAX 0x0000120C")]
        public const int URLACTION_ACTIVEX_CURR_MAX = 0x0000120C;

        [NativeTypeName("#define URLACTION_ACTIVEX_MAX 0x000013ff")]
        public const int URLACTION_ACTIVEX_MAX = 0x000013ff;

        [NativeTypeName("#define URLACTION_SCRIPT_MIN 0x00001400")]
        public const int URLACTION_SCRIPT_MIN = 0x00001400;

        [NativeTypeName("#define URLACTION_SCRIPT_RUN 0x00001400")]
        public const int URLACTION_SCRIPT_RUN = 0x00001400;

        [NativeTypeName("#define URLACTION_SCRIPT_JAVA_USE 0x00001402")]
        public const int URLACTION_SCRIPT_JAVA_USE = 0x00001402;

        [NativeTypeName("#define URLACTION_SCRIPT_SAFE_ACTIVEX 0x00001405")]
        public const int URLACTION_SCRIPT_SAFE_ACTIVEX = 0x00001405;

        [NativeTypeName("#define URLACTION_CROSS_DOMAIN_DATA 0x00001406")]
        public const int URLACTION_CROSS_DOMAIN_DATA = 0x00001406;

        [NativeTypeName("#define URLACTION_SCRIPT_PASTE 0x00001407")]
        public const int URLACTION_SCRIPT_PASTE = 0x00001407;

        [NativeTypeName("#define URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE 0x00001408")]
        public const int URLACTION_ALLOW_XDOMAIN_SUBFRAME_RESIZE = 0x00001408;

        [NativeTypeName("#define URLACTION_SCRIPT_XSSFILTER 0x00001409")]
        public const int URLACTION_SCRIPT_XSSFILTER = 0x00001409;

        [NativeTypeName("#define URLACTION_SCRIPT_NAVIGATE 0x0000140A")]
        public const int URLACTION_SCRIPT_NAVIGATE = 0x0000140A;

        [NativeTypeName("#define URLACTION_PLUGGABLE_PROTOCOL_XHR 0x0000140B")]
        public const int URLACTION_PLUGGABLE_PROTOCOL_XHR = 0x0000140B;

        [NativeTypeName("#define URLACTION_ALLOW_VBSCRIPT_IE 0x0000140C")]
        public const int URLACTION_ALLOW_VBSCRIPT_IE = 0x0000140C;

        [NativeTypeName("#define URLACTION_ALLOW_JSCRIPT_IE 0x0000140D")]
        public const int URLACTION_ALLOW_JSCRIPT_IE = 0x0000140D;

        [NativeTypeName("#define URLACTION_SCRIPT_CURR_MAX 0x0000140D")]
        public const int URLACTION_SCRIPT_CURR_MAX = 0x0000140D;

        [NativeTypeName("#define URLACTION_SCRIPT_MAX 0x000015ff")]
        public const int URLACTION_SCRIPT_MAX = 0x000015ff;

        [NativeTypeName("#define URLACTION_HTML_MIN 0x00001600")]
        public const int URLACTION_HTML_MIN = 0x00001600;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS 0x00001601")]
        public const int URLACTION_HTML_SUBMIT_FORMS = 0x00001601;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_FROM 0x00001602")]
        public const int URLACTION_HTML_SUBMIT_FORMS_FROM = 0x00001602;

        [NativeTypeName("#define URLACTION_HTML_SUBMIT_FORMS_TO 0x00001603")]
        public const int URLACTION_HTML_SUBMIT_FORMS_TO = 0x00001603;

        [NativeTypeName("#define URLACTION_HTML_FONT_DOWNLOAD 0x00001604")]
        public const int URLACTION_HTML_FONT_DOWNLOAD = 0x00001604;

        [NativeTypeName("#define URLACTION_HTML_JAVA_RUN 0x00001605")]
        public const int URLACTION_HTML_JAVA_RUN = 0x00001605;

        [NativeTypeName("#define URLACTION_HTML_USERDATA_SAVE 0x00001606")]
        public const int URLACTION_HTML_USERDATA_SAVE = 0x00001606;

        [NativeTypeName("#define URLACTION_HTML_SUBFRAME_NAVIGATE 0x00001607")]
        public const int URLACTION_HTML_SUBFRAME_NAVIGATE = 0x00001607;

        [NativeTypeName("#define URLACTION_HTML_META_REFRESH 0x00001608")]
        public const int URLACTION_HTML_META_REFRESH = 0x00001608;

        [NativeTypeName("#define URLACTION_HTML_MIXED_CONTENT 0x00001609")]
        public const int URLACTION_HTML_MIXED_CONTENT = 0x00001609;

        [NativeTypeName("#define URLACTION_HTML_INCLUDE_FILE_PATH 0x0000160A")]
        public const int URLACTION_HTML_INCLUDE_FILE_PATH = 0x0000160A;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML 0x0000160B")]
        public const int URLACTION_HTML_ALLOW_INJECTED_DYNAMIC_HTML = 0x0000160B;

        [NativeTypeName("#define URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE 0x0000160C")]
        public const int URLACTION_HTML_REQUIRE_UTF8_DOCUMENT_CODEPAGE = 0x0000160C;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS 0x0000160D")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_CANVAS = 0x0000160D;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_WINDOW_CLOSE 0x0000160E")]
        public const int URLACTION_HTML_ALLOW_WINDOW_CLOSE = 0x0000160E;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER 0x0000160F")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_WEBWORKER = 0x0000160F;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK 0x00001610")]
        public const int URLACTION_HTML_ALLOW_CROSS_DOMAIN_TEXTTRACK = 0x00001610;

        [NativeTypeName("#define URLACTION_HTML_ALLOW_INDEXEDDB 0x00001611")]
        public const int URLACTION_HTML_ALLOW_INDEXEDDB = 0x00001611;

        [NativeTypeName("#define URLACTION_HTML_MAX 0x000017ff")]
        public const int URLACTION_HTML_MAX = 0x000017ff;

        [NativeTypeName("#define URLACTION_SHELL_MIN 0x00001800")]
        public const int URLACTION_SHELL_MIN = 0x00001800;

        [NativeTypeName("#define URLACTION_SHELL_INSTALL_DTITEMS 0x00001800")]
        public const int URLACTION_SHELL_INSTALL_DTITEMS = 0x00001800;

        [NativeTypeName("#define URLACTION_SHELL_MOVE_OR_COPY 0x00001802")]
        public const int URLACTION_SHELL_MOVE_OR_COPY = 0x00001802;

        [NativeTypeName("#define URLACTION_SHELL_FILE_DOWNLOAD 0x00001803")]
        public const int URLACTION_SHELL_FILE_DOWNLOAD = 0x00001803;

        [NativeTypeName("#define URLACTION_SHELL_VERB 0x00001804")]
        public const int URLACTION_SHELL_VERB = 0x00001804;

        [NativeTypeName("#define URLACTION_SHELL_WEBVIEW_VERB 0x00001805")]
        public const int URLACTION_SHELL_WEBVIEW_VERB = 0x00001805;

        [NativeTypeName("#define URLACTION_SHELL_SHELLEXECUTE 0x00001806")]
        public const int URLACTION_SHELL_SHELLEXECUTE = 0x00001806;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_HIGHRISK 0x00001806")]
        public const int URLACTION_SHELL_EXECUTE_HIGHRISK = 0x00001806;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_MODRISK 0x00001807")]
        public const int URLACTION_SHELL_EXECUTE_MODRISK = 0x00001807;

        [NativeTypeName("#define URLACTION_SHELL_EXECUTE_LOWRISK 0x00001808")]
        public const int URLACTION_SHELL_EXECUTE_LOWRISK = 0x00001808;

        [NativeTypeName("#define URLACTION_SHELL_POPUPMGR 0x00001809")]
        public const int URLACTION_SHELL_POPUPMGR = 0x00001809;

        [NativeTypeName("#define URLACTION_SHELL_RTF_OBJECTS_LOAD 0x0000180A")]
        public const int URLACTION_SHELL_RTF_OBJECTS_LOAD = 0x0000180A;

        [NativeTypeName("#define URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY 0x0000180B")]
        public const int URLACTION_SHELL_ENHANCED_DRAGDROP_SECURITY = 0x0000180B;

        [NativeTypeName("#define URLACTION_SHELL_EXTENSIONSECURITY 0x0000180C")]
        public const int URLACTION_SHELL_EXTENSIONSECURITY = 0x0000180C;

        [NativeTypeName("#define URLACTION_SHELL_SECURE_DRAGSOURCE 0x0000180D")]
        public const int URLACTION_SHELL_SECURE_DRAGSOURCE = 0x0000180D;

        [NativeTypeName("#define URLACTION_SHELL_REMOTEQUERY 0x0000180E")]
        public const int URLACTION_SHELL_REMOTEQUERY = 0x0000180E;

        [NativeTypeName("#define URLACTION_SHELL_PREVIEW 0x0000180F")]
        public const int URLACTION_SHELL_PREVIEW = 0x0000180F;

        [NativeTypeName("#define URLACTION_SHELL_SHARE 0x00001810")]
        public const int URLACTION_SHELL_SHARE = 0x00001810;

        [NativeTypeName("#define URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE 0x00001811")]
        public const int URLACTION_SHELL_ALLOW_CROSS_SITE_SHARE = 0x00001811;

        [NativeTypeName("#define URLACTION_SHELL_TOCTOU_RISK 0x00001812")]
        public const int URLACTION_SHELL_TOCTOU_RISK = 0x00001812;

        [NativeTypeName("#define URLACTION_SHELL_CURR_MAX 0x00001812")]
        public const int URLACTION_SHELL_CURR_MAX = 0x00001812;

        [NativeTypeName("#define URLACTION_SHELL_MAX 0x000019ff")]
        public const int URLACTION_SHELL_MAX = 0x000019ff;

        [NativeTypeName("#define URLACTION_NETWORK_MIN 0x00001A00")]
        public const int URLACTION_NETWORK_MIN = 0x00001A00;

        [NativeTypeName("#define URLACTION_CREDENTIALS_USE 0x00001A00")]
        public const int URLACTION_CREDENTIALS_USE = 0x00001A00;

        [NativeTypeName("#define URLACTION_AUTHENTICATE_CLIENT 0x00001A01")]
        public const int URLACTION_AUTHENTICATE_CLIENT = 0x00001A01;

        [NativeTypeName("#define URLACTION_COOKIES 0x00001A02")]
        public const int URLACTION_COOKIES = 0x00001A02;

        [NativeTypeName("#define URLACTION_COOKIES_SESSION 0x00001A03")]
        public const int URLACTION_COOKIES_SESSION = 0x00001A03;

        [NativeTypeName("#define URLACTION_CLIENT_CERT_PROMPT 0x00001A04")]
        public const int URLACTION_CLIENT_CERT_PROMPT = 0x00001A04;

        [NativeTypeName("#define URLACTION_COOKIES_THIRD_PARTY 0x00001A05")]
        public const int URLACTION_COOKIES_THIRD_PARTY = 0x00001A05;

        [NativeTypeName("#define URLACTION_COOKIES_SESSION_THIRD_PARTY 0x00001A06")]
        public const int URLACTION_COOKIES_SESSION_THIRD_PARTY = 0x00001A06;

        [NativeTypeName("#define URLACTION_COOKIES_ENABLED 0x00001A10")]
        public const int URLACTION_COOKIES_ENABLED = 0x00001A10;

        [NativeTypeName("#define URLACTION_NETWORK_CURR_MAX 0x00001A10")]
        public const int URLACTION_NETWORK_CURR_MAX = 0x00001A10;

        [NativeTypeName("#define URLACTION_NETWORK_MAX 0x00001Bff")]
        public const int URLACTION_NETWORK_MAX = 0x00001Bff;

        [NativeTypeName("#define URLACTION_JAVA_MIN 0x00001C00")]
        public const int URLACTION_JAVA_MIN = 0x00001C00;

        [NativeTypeName("#define URLACTION_JAVA_PERMISSIONS 0x00001C00")]
        public const int URLACTION_JAVA_PERMISSIONS = 0x00001C00;

        [NativeTypeName("#define URLACTION_JAVA_CURR_MAX 0x00001C00")]
        public const int URLACTION_JAVA_CURR_MAX = 0x00001C00;

        [NativeTypeName("#define URLACTION_JAVA_MAX 0x00001Cff")]
        public const int URLACTION_JAVA_MAX = 0x00001Cff;

        [NativeTypeName("#define URLACTION_INFODELIVERY_MIN 0x00001D00")]
        public const int URLACTION_INFODELIVERY_MIN = 0x00001D00;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_CHANNELS 0x00001D00")]
        public const int URLACTION_INFODELIVERY_NO_ADDING_CHANNELS = 0x00001D00;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_CHANNELS 0x00001D01")]
        public const int URLACTION_INFODELIVERY_NO_EDITING_CHANNELS = 0x00001D01;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS 0x00001D02")]
        public const int URLACTION_INFODELIVERY_NO_REMOVING_CHANNELS = 0x00001D02;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS 0x00001D03")]
        public const int URLACTION_INFODELIVERY_NO_ADDING_SUBSCRIPTIONS = 0x00001D03;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS 0x00001D04")]
        public const int URLACTION_INFODELIVERY_NO_EDITING_SUBSCRIPTIONS = 0x00001D04;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS 0x00001D05")]
        public const int URLACTION_INFODELIVERY_NO_REMOVING_SUBSCRIPTIONS = 0x00001D05;

        [NativeTypeName("#define URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING 0x00001D06")]
        public const int URLACTION_INFODELIVERY_NO_CHANNEL_LOGGING = 0x00001D06;

        [NativeTypeName("#define URLACTION_INFODELIVERY_CURR_MAX 0x00001D06")]
        public const int URLACTION_INFODELIVERY_CURR_MAX = 0x00001D06;

        [NativeTypeName("#define URLACTION_INFODELIVERY_MAX 0x00001Dff")]
        public const int URLACTION_INFODELIVERY_MAX = 0x00001Dff;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MIN 0x00001E00")]
        public const int URLACTION_CHANNEL_SOFTDIST_MIN = 0x00001E00;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_PERMISSIONS 0x00001E05")]
        public const int URLACTION_CHANNEL_SOFTDIST_PERMISSIONS = 0x00001E05;

        [NativeTypeName("#define URLACTION_CHANNEL_SOFTDIST_MAX 0x00001Eff")]
        public const int URLACTION_CHANNEL_SOFTDIST_MAX = 0x00001Eff;

        [NativeTypeName("#define URLACTION_DOTNET_USERCONTROLS 0x00002005")]
        public const int URLACTION_DOTNET_USERCONTROLS = 0x00002005;

        [NativeTypeName("#define URLACTION_BEHAVIOR_MIN 0x00002000")]
        public const int URLACTION_BEHAVIOR_MIN = 0x00002000;

        [NativeTypeName("#define URLACTION_BEHAVIOR_RUN 0x00002000")]
        public const int URLACTION_BEHAVIOR_RUN = 0x00002000;

        [NativeTypeName("#define URLACTION_FEATURE_MIN 0x00002100")]
        public const int URLACTION_FEATURE_MIN = 0x00002100;

        [NativeTypeName("#define URLACTION_FEATURE_MIME_SNIFFING 0x00002100")]
        public const int URLACTION_FEATURE_MIME_SNIFFING = 0x00002100;

        [NativeTypeName("#define URLACTION_FEATURE_ZONE_ELEVATION 0x00002101")]
        public const int URLACTION_FEATURE_ZONE_ELEVATION = 0x00002101;

        [NativeTypeName("#define URLACTION_FEATURE_WINDOW_RESTRICTIONS 0x00002102")]
        public const int URLACTION_FEATURE_WINDOW_RESTRICTIONS = 0x00002102;

        [NativeTypeName("#define URLACTION_FEATURE_SCRIPT_STATUS_BAR 0x00002103")]
        public const int URLACTION_FEATURE_SCRIPT_STATUS_BAR = 0x00002103;

        [NativeTypeName("#define URLACTION_FEATURE_FORCE_ADDR_AND_STATUS 0x00002104")]
        public const int URLACTION_FEATURE_FORCE_ADDR_AND_STATUS = 0x00002104;

        [NativeTypeName("#define URLACTION_FEATURE_BLOCK_INPUT_PROMPTS 0x00002105")]
        public const int URLACTION_FEATURE_BLOCK_INPUT_PROMPTS = 0x00002105;

        [NativeTypeName("#define URLACTION_FEATURE_DATA_BINDING 0x00002106")]
        public const int URLACTION_FEATURE_DATA_BINDING = 0x00002106;

        [NativeTypeName("#define URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE 0x00002107")]
        public const int URLACTION_FEATURE_CROSSDOMAIN_FOCUS_CHANGE = 0x00002107;

        [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN 0x00002200")]
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI_MIN = 0x00002200;

        [NativeTypeName("#define URLACTION_AUTOMATIC_DOWNLOAD_UI 0x00002200")]
        public const int URLACTION_AUTOMATIC_DOWNLOAD_UI = 0x00002200;

        [NativeTypeName("#define URLACTION_AUTOMATIC_ACTIVEX_UI 0x00002201")]
        public const int URLACTION_AUTOMATIC_ACTIVEX_UI = 0x00002201;

        [NativeTypeName("#define URLACTION_ALLOW_RESTRICTEDPROTOCOLS 0x00002300")]
        public const int URLACTION_ALLOW_RESTRICTEDPROTOCOLS = 0x00002300;

        [NativeTypeName("#define URLACTION_ALLOW_APEVALUATION 0x00002301")]
        public const int URLACTION_ALLOW_APEVALUATION = 0x00002301;

        [NativeTypeName("#define URLACTION_ALLOW_XHR_EVALUATION 0x00002302")]
        public const int URLACTION_ALLOW_XHR_EVALUATION = 0x00002302;

        [NativeTypeName("#define URLACTION_WINDOWS_BROWSER_APPLICATIONS 0x00002400")]
        public const int URLACTION_WINDOWS_BROWSER_APPLICATIONS = 0x00002400;

        [NativeTypeName("#define URLACTION_XPS_DOCUMENTS 0x00002401")]
        public const int URLACTION_XPS_DOCUMENTS = 0x00002401;

        [NativeTypeName("#define URLACTION_LOOSE_XAML 0x00002402")]
        public const int URLACTION_LOOSE_XAML = 0x00002402;

        [NativeTypeName("#define URLACTION_LOWRIGHTS 0x00002500")]
        public const int URLACTION_LOWRIGHTS = 0x00002500;

        [NativeTypeName("#define URLACTION_WINFX_SETUP 0x00002600")]
        public const int URLACTION_WINFX_SETUP = 0x00002600;

        [NativeTypeName("#define URLACTION_INPRIVATE_BLOCKING 0x00002700")]
        public const int URLACTION_INPRIVATE_BLOCKING = 0x00002700;

        [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO 0x00002701")]
        public const int URLACTION_ALLOW_AUDIO_VIDEO = 0x00002701;

        [NativeTypeName("#define URLACTION_ALLOW_ACTIVEX_FILTERING 0x00002702")]
        public const int URLACTION_ALLOW_ACTIVEX_FILTERING = 0x00002702;

        [NativeTypeName("#define URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING 0x00002703")]
        public const int URLACTION_ALLOW_STRUCTURED_STORAGE_SNIFFING = 0x00002703;

        [NativeTypeName("#define URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS 0x00002704")]
        public const int URLACTION_ALLOW_AUDIO_VIDEO_PLUGINS = 0x00002704;

        [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT 0x00002705")]
        public const int URLACTION_ALLOW_ZONE_ELEVATION_VIA_OPT_OUT = 0x00002705;

        [NativeTypeName("#define URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION 0x00002706")]
        public const int URLACTION_ALLOW_ZONE_ELEVATION_OPT_OUT_ADDITION = 0x00002706;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW 0x00002708")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_WITHIN_WINDOW = 0x00002708;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS 0x00002709")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_DROP_ACROSS_WINDOWS = 0x00002709;

        [NativeTypeName("#define URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST 0x0000270A")]
        public const int URLACTION_ALLOW_CROSSDOMAIN_APPCACHE_MANIFEST = 0x0000270A;

        [NativeTypeName("#define URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS 0x0000270B")]
        public const int URLACTION_ALLOW_RENDER_LEGACY_DXTFILTERS = 0x0000270B;

        [NativeTypeName("#define URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX 0x0000270C")]
        public const int URLACTION_ALLOW_ANTIMALWARE_SCANNING_OF_ACTIVEX = 0x0000270C;

        [NativeTypeName("#define URLACTION_ALLOW_CSS_EXPRESSIONS 0x0000270D")]
        public const int URLACTION_ALLOW_CSS_EXPRESSIONS = 0x0000270D;
    }
}
