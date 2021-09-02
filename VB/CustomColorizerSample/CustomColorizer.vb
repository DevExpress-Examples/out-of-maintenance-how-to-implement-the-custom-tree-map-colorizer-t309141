Imports System
Imports DevExpress.Xpf.TreeMap
Imports System.Windows.Media


Namespace CustomColorizerSample
	Friend Class CustomColorizer
		Inherits TreeMapPaletteColorizerBase

		Public Overrides Function GetItemColor(ByVal item As TreeMapItem, ByVal group As TreeMapItemGroupInfo) As Color?
			If item.Children.Count = 0 Then
				Dim itemColor As Color = Palette(group.ItemIndex Mod Palette.Count)
				Dim groupColor As Color = Palette(group.GroupIndex Mod Palette.Count)
'INSTANT VB WARNING: Instant VB cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
				Dim proportion As Double = (item.Value - group.MinValue) / (group.MaxValue - group.MinValue)

				Return New Color With {
					.A = 255,
					.R = CByte(Math.Truncate(proportion * itemColor.R + (1-proportion)*groupColor.R)),
					.G = CByte(Math.Truncate(proportion * itemColor.G + (1 - proportion) * groupColor.G)),
					.B = CByte(Math.Truncate(proportion * itemColor.B + (1 - proportion) * groupColor.B))
				}
			Else
				Return Palette(Palette.Count - 1 - group.GroupLevel Mod Palette.Count)
			End If
		End Function

		Protected Overrides Function CreateObject() As TreeMapDependencyObject
			Return New CustomColorizer()
		End Function
	End Class
End Namespace
