using NVP.API.Nodes;

namespace OdaX.AcadHyperlink 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadHyperlink_Constructor : INode 
		{
		public OdaX.IAcadHyperlink _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadHyperlink;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadHyperlink_ConstructorCast : INode 
		{
		public OdaX.IAcadHyperlink _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadHyperlink;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns a link to an external file.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		[NodeInput("URLPath", typeof(System.String))]
		public class Set_URL : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.URL = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns a link to an external file.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		public class URL : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.URL);

			}
		}


		///<summary>
		///Specifies or returns a text description of the URL.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		[NodeInput("Description", typeof(System.String))]
		public class Set_URLDescription : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.URLDescription = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns a text description of the URL.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		public class URLDescription : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.URLDescription);

			}
		}


		///<summary>
		///Returns the Application object.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Deletes a specified object.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		public class Delete : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Delete();
				return null;
			}
		}


		///<summary>
		///Specifies or returns the named location within a file that is referenced by a URL.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		[NodeInput("Location", typeof(System.String))]
		public class Set_URLNamedLocation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.URLNamedLocation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the named location within a file that is referenced by a URL.
		///</summary>
		[NodeInput("AcadHyperlink", typeof(object))]
		public class URLNamedLocation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.URLNamedLocation);

			}
		}
}
