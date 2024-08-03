using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PostalAddress 
{

	[NVP_Manifest(
		Id = "5030A89F-7AB9-4DFE-A0B8-F0CD1DA67D7F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.PostalAddress_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "_PostalAddress_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "4CFA73C3-B806-4CE8-AB20-91812D61E978", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.PostalAddress_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "_PostalAddress_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "7310A7C6-77EB-41C4-B48B-DEF33F67890D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Addressee", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Addressee", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "58F06E36-CF35-4280-9382-CEC23DBE95B0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Set_Addressee", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Set_Addressee", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "D3940BBE-0C72-4E24-B1C6-8F16C3E57988", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.AddressLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "AddressLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "64F1B8B7-4746-44FB-BED0-A0AEEDB1F396", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Set_AddressLines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Set_AddressLines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "68728A7C-8389-4F4B-9AAB-718A4157331E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.PostalBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "PostalBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "19DCF374-36C7-467C-9B90-96E392EBE253", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Set_PostalBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Set_PostalBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "785E2441-1E74-4E88-8D7D-F072346392A8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Town", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Town", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "A53342CF-B959-41C2-9BAF-7D320B67C477", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Set_Town", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Set_Town", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "80B90678-7C4A-43A2-A59D-749497D72312", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Region", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Region", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "CE76B0B3-0D7E-44F9-8CDB-604EA7CC6938", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Set_Region", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Set_Region", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "81D0A2D3-2F80-480E-9CCE-6B1490C89F7C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Postcode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Postcode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "6C2767BA-F204-441E-AD88-3156C61279B9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Set_Postcode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Set_Postcode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "52DE55CD-012B-4FD3-A92C-524CCA70E5CB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Country", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Country", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "D79672F3-B178-446F-A4A4-07C8ED7476BA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PostalAddress.Set_Country", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PostalAddress", 
		NodeName = "Set_Country", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
