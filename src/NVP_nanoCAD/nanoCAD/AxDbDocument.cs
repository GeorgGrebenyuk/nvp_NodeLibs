using NVP.API.Nodes;

namespace nanoCAD.AxDbDocument 
{
		[NodeInput("dynamic", typeof(object))]
		public class AxDbDocument_Constructor : INode 
		{
		public nanoCAD.IAxDbDocument _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.IAxDbDocument;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AxDbDocument_ConstructorCast : INode 
		{
		public nanoCAD.IAxDbDocument _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.IAxDbDocument;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies the name of the document
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies the name of the document
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Opens document.
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		[NodeInput("FileName", typeof(System.String))]
		[NodeInput("Password", typeof(System.Object))]
		public class Open : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Open(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Saves document.
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		public class Save : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Save();
				return null;
			}
		}


		///<summary>
		///Saves document with new name.
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		[NodeInput("FileName", typeof(System.String))]
		[NodeInput("vSecurityParams", typeof(System.Object))]
		public class SaveAs : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SaveAs(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///DxfIn.
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		[NodeInput("FileName", typeof(System.String))]
		[NodeInput("LogFileName", typeof(System.Object))]
		public class DxfIn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DxfIn(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///DxfOut.
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		[NodeInput("FileName", typeof(System.String))]
		[NodeInput("precision", typeof(System.Object))]
		[NodeInput("SaveThumbnailImage", typeof(System.Object))]
		public class DxfOut : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DxfOut(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Retrieves an Application object
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Retrieves an database object
		///</summary>
		[NodeInput("AxDbDocument", typeof(object))]
		public class Database : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Database);

			}
		}
}
