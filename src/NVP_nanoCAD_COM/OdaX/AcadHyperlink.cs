using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a URL and URL description
///</summary>
namespace OdaX.AcadHyperlink 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns a link to an external file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]
	[NodeInput("URLPath", typeof(System.String))]

	///<summary>
	///Specifies or returns a link to an external file.
	///</summary>
	public class Set_URL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.URL = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a link to an external file.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Specifies or returns a link to an external file.
	///</summary>
	public class URL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.URL);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a text description of the URL.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]
	[NodeInput("Description", typeof(System.String))]

	///<summary>
	///Specifies or returns a text description of the URL.
	///</summary>
	public class Set_URLDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.URLDescription = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a text description of the URL.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Specifies or returns a text description of the URL.
	///</summary>
	public class URLDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.URLDescription);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Returns the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Text = "Deletes a specified object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Deletes a specified object.
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the named location within a file that is referenced by a URL.", 
		ViewType = "Modifier")]
	[NodeInput("AcadHyperlink", typeof(object))]
	[NodeInput("Location", typeof(System.String))]

	///<summary>
	///Specifies or returns the named location within a file that is referenced by a URL.
	///</summary>
	public class Set_URLNamedLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.URLNamedLocation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the named location within a file that is referenced by a URL.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlink", typeof(object))]

	///<summary>
	///Specifies or returns the named location within a file that is referenced by a URL.
	///</summary>
	public class URLNamedLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.URLNamedLocation);

		}
	}
}
