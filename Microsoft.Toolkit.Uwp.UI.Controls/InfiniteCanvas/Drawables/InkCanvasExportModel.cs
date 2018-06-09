﻿using System.Collections.Generic;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    internal class InkCanvasExportModel
    {
        public List<IDrawable> DrawableList { get; set; }

        // Create new class from the export model, new version is created with every breaking changes so we could be able to map back from the file when adding new features
        public int Version { get; set; }
    }
}
