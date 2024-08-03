using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ProjectInfo 
{

	[NVP_Manifest(
		Id = "D8815F3F-96AC-4FC5-9077-9C1B405A3617", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.ProjectInfo_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "_ProjectInfo_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ProjectInfo_Constructor : INode 
	{
		public Renga.IProjectInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProjectInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2030A333-199C-44D5-BA21-73021E1854DA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.ProjectInfo_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "_ProjectInfo_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ProjectInfo_ConstructorCast : INode 
	{
		public Renga.IProjectInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProjectInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "25EB5A01-5C69-4B11-ABBC-612F1605E77E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Code", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Code", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProjectInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Code : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Code);

		}
	}


	[NVP_Manifest(
		Id = "852D8007-4CB7-424D-B0AA-E34E445A343E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Set_Code", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Set_Code", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ProjectInfo", typeof(object))]
	[NodeInput("pCode", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Code : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Code = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CC76B832-A8A4-4D07-BA25-034F58A97998", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProjectInfo", typeof(object))]

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
		Id = "C714B013-1F66-487B-8A59-8240CAC85DDE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ProjectInfo", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "671B7E37-EA58-450A-A566-BD38E66B0951", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Stage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Stage", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProjectInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Stage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Stage);

		}
	}


	[NVP_Manifest(
		Id = "01EE2078-4628-4CBE-9D9C-5301E231E276", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Set_Stage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Set_Stage", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ProjectInfo", typeof(object))]
	[NodeInput("pStage", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Stage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Stage = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B8A74220-573E-409F-AC17-CF7BB3A91247", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProjectInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Id = "F890D9F1-27DE-4BB0-9402-CCA7E803AC5E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ProjectInfo", typeof(object))]
	[NodeInput("pDescription", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0418B560-C42D-4D42-BC27-E4E381BEC710", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.GetProperties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "GetProperties", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProjectInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetProperties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProperties);

		}
	}


	[NVP_Manifest(
		Id = "A402FD50-BE69-4F42-879D-1FC0062F1382", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.UniqueId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "UniqueId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProjectInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UniqueId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UniqueId);

		}
	}


	[NVP_Manifest(
		Id = "6243282B-6696-4288-8393-98FBA43576E2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ProjectInfo.UniqueIdS", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ProjectInfo", 
		NodeName = "UniqueIdS", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ProjectInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UniqueIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UniqueIdS);

		}
	}
}
