using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DựÁnBánĐiệnThoại
{
    public partial class DienThi : Component
    {
        public DienThi()
        {
            InitializeComponent();
        }

        public DienThi(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
