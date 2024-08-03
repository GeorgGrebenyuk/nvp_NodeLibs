using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Transform3D 
{

	[NVP_Manifest(
		Id = "0924935D-89DE-479A-AFC7-4282EEE21A80", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.Transform3D_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "_Transform3D_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Transform3D_Constructor : INode 
	{
		public Renga.ITransform3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ITransform3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F5769645-E71D-4B14-96FC-A71A57A853F0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.Transform3D_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "_Transform3D_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Transform3D_ConstructorCast : INode 
	{
		public Renga.ITransform3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ITransform3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3964D7D9-F027-4D3E-936F-1621A488EF96", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.GetElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "GetElement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("rowIndex", typeof(System.Int32))]
	[NodeInput("columnIndex", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetElement(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "1993AB53-5ECB-4511-98BE-0AD1F27E244D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.SetElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "SetElement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("rowIndex", typeof(System.Int32))]
	[NodeInput("columnIndex", typeof(System.Int32))]
	[NodeInput("value", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetElement(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4617988A-4B17-41BD-959F-6E9C388985D9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.AddTranslation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "AddTranslation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("translation", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class AddTranslation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddTranslation(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25FB8B85-15B0-4074-9DF4-6DB73CFF5781", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.AddRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "AddRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("axis", typeof(System.Object))]
	[NodeInput("angle", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class AddRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddRotation(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ACABC939-0B3A-4F21-BAB4-EFABCB557E11", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.GetCopy", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "GetCopy", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCopy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCopy);

		}
	}


	[NVP_Manifest(
		Id = "07BA11F7-0F91-449E-8D77-E2036617246D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.GetMultiplied", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "GetMultiplied", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("pTransform", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetMultiplied : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMultiplied(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "1E62190F-6823-47EA-89B8-B7639DE6B5A4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.TransformPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "TransformPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("pPoint", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class TransformPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransformPoint(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "9E223A10-ADD9-4A8F-960A-E8ED00F4527F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Transform3D.TransformVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Transform3D", 
		NodeName = "TransformVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Transform3D", typeof(object))]
	[NodeInput("pVector", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class TransformVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TransformVector(inputs[1].Value));

		}
	}
}
