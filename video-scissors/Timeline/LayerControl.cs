﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scissors.Timeline
{
    public partial class LayerControl : UserControl, IControl
    {
        private bool toggleLock;
        private bool toggleVisibility;

        public LayerControl()
        {
            InitializeComponent();
            toggleLock = false;
            toggleLockButton.BackColor = ColorProvider.GetToggleColor(false);
            toggleVisibility = false;
            toggleVisibilityButton.BackColor = ColorProvider.GetToggleColor(false);
        }

        public event EventHandler RemoveClicked;
        public event EventHandler AddClicked;
        public event EventHandler MoveUpClicked;
        public event EventHandler MoveDownClicked;
        public event EventHandler<ToggleEventArgs> ToggleLockClicked;
        public event EventHandler<ToggleEventArgs> ToggleVisibilityClicked;

        public bool IsLockToggled { get { return toggleLock; } }
        public bool IsVisibilityToggled { get { return toggleVisibility; } }

        private void removeLayer_Click(object sender, EventArgs e)
        {
            if (RemoveClicked != null) RemoveClicked.Invoke(this, EventArgs.Empty);
        }

        private void createLayer_Click(object sender, EventArgs e)
        {
            if (AddClicked != null) AddClicked.Invoke(this, EventArgs.Empty);
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            if (MoveUpClicked != null) MoveUpClicked.Invoke(this, EventArgs.Empty);
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            if (MoveDownClicked != null) MoveDownClicked.Invoke(this, EventArgs.Empty);
        }

        private void toggleLock_Click(object sender, EventArgs e)
        {
            toggleLock = !toggleLock;
            toggleLockButton.BackColor = ColorProvider.GetToggleColor(toggleLock);
            if (ToggleLockClicked != null) ToggleLockClicked.Invoke(this, new ToggleEventArgs(toggleLock));
        }

        private void toggleVisibility_Click(object sender, EventArgs e)
        {
            toggleVisibility = !toggleVisibility;
            toggleVisibilityButton.BackColor = ColorProvider.GetToggleColor(toggleVisibility);
            if (ToggleVisibilityClicked != null) ToggleVisibilityClicked.Invoke(this, new ToggleEventArgs(toggleVisibility));
        }
    }
}
