using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_SymToleranceParameter 
{


	[NVP_Manifest(
		Id = "A93078EA-946A-4013-8DCE-0CA61168CE41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceUndefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceUndefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceUndefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceUndefined);

		}
	}


	[NVP_Manifest(
		Id = "FC3ECE00-4CA7-4C93-99BE-40D09FF35C07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceLinear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceLinear", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceLinear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceLinear);

		}
	}


	[NVP_Manifest(
		Id = "22E80E57-B98E-4895-B0E1-508A49477255", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymTolerancePlanar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymTolerancePlanar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymTolerancePlanar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymTolerancePlanar);

		}
	}


	[NVP_Manifest(
		Id = "5513E9D6-9834-4BAE-B767-6EEBD75CC107", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceRound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceRound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceRound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceRound);

		}
	}


	[NVP_Manifest(
		Id = "DDD43165-426D-40B4-BFDB-259CEC766598", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceCylindrical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceCylindrical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceCylindrical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceCylindrical);

		}
	}


	[NVP_Manifest(
		Id = "38D82957-02DF-477A-8F52-A8435D232997", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceProfile);

		}
	}


	[NVP_Manifest(
		Id = "0635F480-20B5-46D8-8FE9-70A35BA3AE86", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceParallel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceParallel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceParallel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceParallel);

		}
	}


	[NVP_Manifest(
		Id = "84D5E156-80EF-449F-9D27-568BA494E78A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymTolerancePerpendicular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymTolerancePerpendicular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymTolerancePerpendicular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymTolerancePerpendicular);

		}
	}


	[NVP_Manifest(
		Id = "625C44A2-A459-47B8-A2AB-929455F4989E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceTilt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceTilt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceTilt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceTilt);

		}
	}


	[NVP_Manifest(
		Id = "EF6C0AC4-CC84-448B-BB10-1C6F0C00BD44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceCoaxiality", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceCoaxiality", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceCoaxiality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceCoaxiality);

		}
	}


	[NVP_Manifest(
		Id = "2E5A3CF0-4EBB-4DBB-B1B8-5445E89F9E82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceSymmetry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceSymmetry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceSymmetry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceSymmetry);

		}
	}


	[NVP_Manifest(
		Id = "77927DDC-432C-42E3-895D-29B705140FDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymTolerancePosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymTolerancePosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymTolerancePosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymTolerancePosition);

		}
	}


	[NVP_Manifest(
		Id = "46D76275-1E3C-42FD-B117-9C56FFC0B143", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceCross", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceCross", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceCross : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceCross);

		}
	}


	[NVP_Manifest(
		Id = "24E0BBE4-09C1-4DB5-BB1E-F746D399B27C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceBeat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceBeat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceBeat);

		}
	}


	[NVP_Manifest(
		Id = "A867C1D9-6954-42DB-B6DB-FB6537722DB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceFullBeat", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceFullBeat", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceFullBeat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceFullBeat);

		}
	}


	[NVP_Manifest(
		Id = "3E7C4FF8-70CF-4EBB-ACD8-301B528779E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceFormProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceFormProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceFormProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceFormProfile);

		}
	}


	[NVP_Manifest(
		Id = "6AAD343A-51AE-48F5-9E0F-874BABA722A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_SymToleranceParameter.enum_mcSymToleranceFormSurface", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_SymToleranceParameter", 
		NodeName = "enum_mcSymToleranceFormSurface", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcSymToleranceFormSurface : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.SymToleranceParameter.mcSymToleranceFormSurface);

		}
	}
}
