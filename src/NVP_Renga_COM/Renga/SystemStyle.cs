using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.SystemStyle 
{

	[NVP_Manifest(
		Id = "AAA3ABC5-74CD-427A-96C2-408F40909DE7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyle.SystemStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyle", 
		NodeName = "_SystemStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SystemStyle_Constructor : INode 
	{
		public Renga.ISystemStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ISystemStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6CBED759-6583-4E41-9456-77F3D535BC9A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyle.SystemStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyle", 
		NodeName = "_SystemStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SystemStyle_ConstructorCast : INode 
	{
		public Renga.ISystemStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ISystemStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "13F7DF6F-5620-498F-BD0C-BFC798BDE513", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyle.SystemCategory", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyle", 
		NodeName = "SystemCategory", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SystemStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SystemCategory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SystemCategory);

		}
	}


	[NVP_Manifest(
		Id = "747ADC22-8203-415C-B1A8-18DCF3947177", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyle.Designation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyle", 
		NodeName = "Designation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SystemStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Designation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Designation);

		}
	}


	[NVP_Manifest(
		Id = "888DCC46-66BC-485E-B54B-B579522FDC3A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyle.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyle", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SystemStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "1DE6BB5A-3C61-4A3A-97B3-F1FB8BE2BA53", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SystemStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "78D58D93-B427-4CAF-8A7D-3C901D663D0E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.SystemStyle.Color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.SystemStyle", 
		NodeName = "Color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("SystemStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Color);

		}
	}
}
