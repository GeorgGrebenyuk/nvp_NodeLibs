using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for an additional block functionality
///</summary>
namespace OdaX.OdaBlock 
{

	[NVP_Manifest(
		Id = "B44C8DD0-54E2-4D17-888D-21F93E06184F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.OdaBlock_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "_OdaBlock_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaBlock_Constructor : INode 
	{
		public OdaX.IOdaBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F92D99B0-F4D5-49E9-8C2D-90C254CF0DAF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.OdaBlock_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "_OdaBlock_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaBlock_ConstructorCast : INode 
	{
		public OdaX.IOdaBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "98098803-0B9B-44D0-81A3-110F47FE068E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.GetReferences", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "GetReferences", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns all references for a block.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns all references for a block.
	///</summary>
	public class GetReferences : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReferences);

		}
	}


	[NVP_Manifest(
		Id = "02F2ECD3-5271-4222-9BB4-43444EF51E93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.isFromOverlayReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "isFromOverlayReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the block is an overlay.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is an overlay.
	///</summary>
	public class isFromOverlayReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isFromOverlayReference);

		}
	}


	[NVP_Manifest(
		Id = "EFDF767E-A221-4C21-88B8-1A37358A93B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.isResolved", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "isResolved", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the block is an external reference with a resolved path.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is an external reference with a resolved path.
	///</summary>
	public class isResolved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isResolved);

		}
	}


	[NVP_Manifest(
		Id = "762485E5-22AA-4581-B2E2-9E10226890F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.isDependent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "isDependent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the block is dependent on an external reference.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is dependent on an external reference.
	///</summary>
	public class isDependent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isDependent);

		}
	}


	[NVP_Manifest(
		Id = "162D83E3-E22A-4061-B834-7ADEE7E82DAF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.isUnloaded", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "isUnloaded", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether the block is an external reference that is unloaded.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is an external reference that is unloaded.
	///</summary>
	public class isUnloaded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isUnloaded);

		}
	}


	[NVP_Manifest(
		Id = "922F3144-55D4-4F8C-9A33-4A38DF0F2971", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaBlock.setOverlaid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaBlock", 
		NodeName = "setOverlaid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specfies whether a block is an overlay.", 
		ViewType = "Modifier")]
	[NodeInput("OdaBlock", typeof(object))]
	[NodeInput("bOverlaid", typeof(System.Object))]

	///<summary>
	///Specfies whether a block is an overlay.
	///</summary>
	public class setOverlaid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.setOverlaid(inputs[1].Value);
			return null;
		}
	}
}
