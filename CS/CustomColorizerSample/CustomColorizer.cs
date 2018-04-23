using DevExpress.Xpf.TreeMap;
using System.Windows.Media;


namespace CustomColorizerSample {
    class CustomColorizer : TreeMapPaletteColorizerBase {
        public override Color? GetItemColor(TreeMapItem item, TreeMapItemGroupInfo group) {
            if (item.Children.Count == 0) {
                Color itemColor = Palette[group.ItemIndex % Palette.Count];
                Color groupColor = Palette[group.GroupIndex % Palette.Count];
                double proportion = (item.Value - group.MinValue) / 
                        (group.MaxValue - group.MinValue);

                return new Color {
                    A = 255,
                    R = (byte)(proportion * itemColor.R + (1-proportion)*groupColor.R),
                    G = (byte)(proportion * itemColor.G + (1 - proportion) * groupColor.G),
                    B = (byte)(proportion * itemColor.B + (1 - proportion) * groupColor.B)
                };
            }
            else
                return Palette[Palette.Count - 1 - group.GroupLevel % Palette.Count];
        }

        protected override TreeMapDependencyObject CreateObject() {
            return new CustomColorizer();
        }
    }
}
