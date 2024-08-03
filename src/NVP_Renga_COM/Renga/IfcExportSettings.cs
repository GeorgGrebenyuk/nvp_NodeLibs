using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.IfcExportSettings 
{

	[NVP_Manifest(
		Id = "C39CE7A6-483E-4B4B-AB98-716960AF2D56", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.IfcExportSettings_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "_IfcExportSettings_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IfcExportSettings_Constructor : INode 
	{
		public Renga.IIfcExportSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IIfcExportSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "FADBBFA6-025D-43B8-9C49-EF4C806177D2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.IfcExportSettings_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "_IfcExportSettings_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class IfcExportSettings_ConstructorCast : INode 
	{
		public Renga.IIfcExportSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IIfcExportSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "99C90D89-8652-4777-9708-251CE270C535", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_ValueMappingFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_ValueMappingFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ValueMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ValueMappingFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ACFEE46B-339D-4C83-BF38-71EEF8FD0320", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.ValueMappingFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "ValueMappingFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ValueMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ValueMappingFilePath);

		}
	}


	[NVP_Manifest(
		Id = "3B21648D-A92E-40C9-B0F4-DA0C78C8BDF8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_Version", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_Version", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("Renga.IfcVersion", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Version = ((Renga.IfcVersion)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D8B4E447-6708-4DA5-99BB-DE100E38ABF4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Version", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Version", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}


	[NVP_Manifest(
		Id = "33FAB9F6-5BCC-4D09-B11D-E64E36C77494", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_EntityTypeMappingFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_EntityTypeMappingFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_EntityTypeMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EntityTypeMappingFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D10CF00A-C04F-4C8D-BC2C-B98BE7D969C1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.EntityTypeMappingFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "EntityTypeMappingFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class EntityTypeMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityTypeMappingFilePath);

		}
	}


	[NVP_Manifest(
		Id = "BB18CFEF-CFA6-4D9C-BECC-37234C5F58C6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_LayerMappingFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_LayerMappingFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("pFilePath", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_LayerMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerMappingFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A42AC737-886F-4A3C-B101-546D65A53F6F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.LayerMappingFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "LayerMappingFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LayerMappingFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerMappingFilePath);

		}
	}


	[NVP_Manifest(
		Id = "95CEF12E-A8E1-4B75-8E1A-21583320BFF8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_ApproximateCurves", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_ApproximateCurves", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("ApproximateCurves", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ApproximateCurves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ApproximateCurves = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "32FC8E71-3500-4A16-B4B9-6280D01FC380", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.ApproximateCurves", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "ApproximateCurves", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ApproximateCurves : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ApproximateCurves);

		}
	}


	[NVP_Manifest(
		Id = "0B519A64-040C-49B1-B0C2-1811A21B4646", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_VoidsAsReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_VoidsAsReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("VoidsAsReference", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_VoidsAsReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VoidsAsReference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5AE3C5DA-ADBD-472E-B0FC-A13C81F37E89", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.VoidsAsReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "VoidsAsReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VoidsAsReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VoidsAsReference);

		}
	}


	[NVP_Manifest(
		Id = "2BCEB027-7ABA-4D98-A2DE-7A7BDB41F71E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_SplitObjectsWithLayeredMaterialIntoParts", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_SplitObjectsWithLayeredMaterialIntoParts", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("SplitObjectsWithLayeredMaterialIntoParts", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_SplitObjectsWithLayeredMaterialIntoParts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SplitObjectsWithLayeredMaterialIntoParts = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DF4D532E-399F-442B-9E06-41624C98FB2F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.SplitObjectsWithLayeredMaterialIntoParts", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "SplitObjectsWithLayeredMaterialIntoParts", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SplitObjectsWithLayeredMaterialIntoParts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SplitObjectsWithLayeredMaterialIntoParts);

		}
	}


	[NVP_Manifest(
		Id = "E60E0EF2-A6DF-4D33-90A9-27A4BB4C810A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.Set_GeometricRepresentationWithoutCutting", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "Set_GeometricRepresentationWithoutCutting", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("IfcExportSettings", typeof(object))]
	[NodeInput("GeometricRepresentationWithoutCutting", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_GeometricRepresentationWithoutCutting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GeometricRepresentationWithoutCutting = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "976B4557-6CA4-4699-AFA1-FC0E953828B0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.IfcExportSettings.GeometricRepresentationWithoutCutting", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.IfcExportSettings", 
		NodeName = "GeometricRepresentationWithoutCutting", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("IfcExportSettings", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GeometricRepresentationWithoutCutting : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GeometricRepresentationWithoutCutting);

		}
	}
}
