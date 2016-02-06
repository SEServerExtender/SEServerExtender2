using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SEServerExtender
{
	public partial class SEServerExtender : ServiceBase
	{
		public SEServerExtender( )
		{
			InitializeComponent( );
		}

		protected override void OnStart( string[ ] args )
		{
		}

		protected override void OnStop( )
		{
		}
	}
}
