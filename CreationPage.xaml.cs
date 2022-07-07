//  CK Chronicler - a Crusader Kings campaign tracker.
//  Copyright (C) 2022 Jack Sanders
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//   You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System.Windows.Controls;

namespace CKChronicler;

public partial class CreationPage : Page
{
    public CreationPage()
    {
        InitializeComponent();
    }


    private void UpdateCharPreviewText(object sender, TextChangedEventArgs e) {
        string rank = CharRank.Text.Length > 0 ? CharRank.Text : "";
        string name = CharName.Text.Length > 0 ? " " + CharName.Text : "";
        string title = CharTitle.Text.Length > 0 ? " of " + CharTitle.Text : "";

        CharPreview.Text = $"{rank}{name}{title}";
    }
}