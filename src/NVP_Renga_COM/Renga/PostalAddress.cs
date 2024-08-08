using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PostalAddress 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PostalAddress_Constructor : INode 
	{
		public Renga.IPostalAddress _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPostalAddress;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PostalAddress_ConstructorCast : INode 
	{
		public Renga.IPostalAddress _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPostalAddress;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Addressee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Addressee);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PostalAddress", typeof(object))]
	[NodeInput("pAddressee", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Addressee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Addressee = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AddressLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddressLines);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Set_AddressLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddressLines[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PostalBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PostalBox);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PostalAddress", typeof(object))]
	[NodeInput("pPostalBox", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_PostalBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PostalBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Town : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Town);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PostalAddress", typeof(object))]
	[NodeInput("pTown", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Town : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Town = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Region : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Region);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PostalAddress", typeof(object))]
	[NodeInput("pRegion", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Region : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Region = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Postcode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Postcode);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PostalAddress", typeof(object))]
	[NodeInput("pPostalCode", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Postcode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Postcode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("PostalAddress", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Country : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Country);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("PostalAddress", typeof(object))]
	[NodeInput("pCountry", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Country : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Country = inputs[1].Value;
			return null;
		}
	}
}
