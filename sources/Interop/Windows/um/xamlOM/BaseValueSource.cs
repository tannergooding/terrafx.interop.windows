// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum BaseValueSource
    {
        BaseValueSourceUnknown = 0,
        BaseValueSourceDefault = (BaseValueSourceUnknown + 1),
        BaseValueSourceBuiltInStyle = (BaseValueSourceDefault + 1),
        BaseValueSourceStyle = (BaseValueSourceBuiltInStyle + 1),
        BaseValueSourceLocal = (BaseValueSourceStyle + 1),
        Inherited = (BaseValueSourceLocal + 1),
        DefaultStyleTrigger = (Inherited + 1),
        TemplateTrigger = (DefaultStyleTrigger + 1),
        StyleTrigger = (TemplateTrigger + 1),
        ImplicitStyleReference = (StyleTrigger + 1),
        ParentTemplate = (ImplicitStyleReference + 1),
        ParentTemplateTrigger = (ParentTemplate + 1),
        Animation = (ParentTemplateTrigger + 1),
        Coercion = (Animation + 1),
        BaseValueSourceVisualState = (Coercion + 1),
    }
}
