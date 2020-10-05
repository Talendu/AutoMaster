using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMaster
{
	class MyMessage
    {
        public const int MSG_TX = 1;
        public const int MSG_RX = 2;
        public const int MSG_INFO = 3;
        public const int MSG_WARNING = 4;
        public const int MSG_ERROR = 5;
		public int what;
		public object obj;

		public MyMessage()
		{

		}
		public MyMessage(int what)
		{
			this.what = what;
		}
		public MyMessage(int what, object obj)
		{
			this.what = what;
			this.obj = obj;
		}
		public void SetObj(object obj)
		{
			this.obj = obj;
		}
		public object GetObj()
		{
			return this.obj;
		}
		public void SetWhat(int what)
		{
			this.what = what;
		}
		public int GetWhat()
		{
			return this.what;
		}
	}
}
