using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcInsertUnits 
{


	[NVP_Manifest(
		Id = "240C584E-C8E1-478D-BBB8-0D5EE2DA5FC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsUnitless", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsUnitless", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsUnitless : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsUnitless);

		}
	}


	[NVP_Manifest(
		Id = "C778F2B3-E536-4563-A8F1-0067F0DDD50A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsInches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsInches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsInches);

		}
	}


	[NVP_Manifest(
		Id = "DB9411CA-E1A3-48B8-8D3D-DC1D711ED2E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsFeet);

		}
	}


	[NVP_Manifest(
		Id = "AB19E157-02D8-433F-9431-56C88CFBF20F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsMiles", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsMiles", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsMiles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsMiles);

		}
	}


	[NVP_Manifest(
		Id = "7D61D0A3-A4CC-4998-B19C-75384943DF32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsMillimeters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsMillimeters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsMillimeters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsMillimeters);

		}
	}


	[NVP_Manifest(
		Id = "5A7EDC39-2FDC-4DC9-8F22-23C82909B3DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsCentimeters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsCentimeters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsCentimeters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsCentimeters);

		}
	}


	[NVP_Manifest(
		Id = "413C3FEA-807E-4276-BC17-4260CC38F2C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsMeters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsMeters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsMeters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsMeters);

		}
	}


	[NVP_Manifest(
		Id = "27F96207-E843-4712-BF50-3FEBA71B4864", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsKilometers", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsKilometers", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsKilometers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsKilometers);

		}
	}


	[NVP_Manifest(
		Id = "3C564C8D-86D0-4812-A078-59D66CB6C568", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsMicroinches", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsMicroinches", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsMicroinches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsMicroinches);

		}
	}


	[NVP_Manifest(
		Id = "80C79F16-BEDC-4DEC-A559-867B3330812A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsMils", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsMils", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsMils : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsMils);

		}
	}


	[NVP_Manifest(
		Id = "F41B15D0-0F2F-4ED6-A76D-0F5AA79609D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsYards", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsYards", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsYards : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsYards);

		}
	}


	[NVP_Manifest(
		Id = "4B29CF00-3405-49B6-811E-7D37C357778F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsAngstroms", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsAngstroms", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsAngstroms : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsAngstroms);

		}
	}


	[NVP_Manifest(
		Id = "8F6625F0-DE00-47B6-825E-904D3A99F9B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsNanometers", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsNanometers", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsNanometers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsNanometers);

		}
	}


	[NVP_Manifest(
		Id = "56026C85-B955-4F11-9209-67A2EF5FA783", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsMicrons", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsMicrons", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsMicrons : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsMicrons);

		}
	}


	[NVP_Manifest(
		Id = "320E9A3D-8082-4EBF-922A-940BC1EAD6E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsDecimeters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsDecimeters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsDecimeters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsDecimeters);

		}
	}


	[NVP_Manifest(
		Id = "296C3332-1E72-40B8-AFB6-9A5C63C244AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsDecameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsDecameters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsDecameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsDecameters);

		}
	}


	[NVP_Manifest(
		Id = "A22DDECA-C25E-40F1-B333-DBA938375D32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsHectometers", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsHectometers", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsHectometers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsHectometers);

		}
	}


	[NVP_Manifest(
		Id = "9FD6BB6C-E388-4C0B-B225-6F8426E3B08E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsGigameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsGigameters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsGigameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsGigameters);

		}
	}


	[NVP_Manifest(
		Id = "A70CE0EA-6D1A-4FFB-8CC8-9DD657A913BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsAstronomicalUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsAstronomicalUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsAstronomicalUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsAstronomicalUnits);

		}
	}


	[NVP_Manifest(
		Id = "0E76281A-6106-4DF7-9CFF-6C64345DC42F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsLightYears", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsLightYears", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsLightYears : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsLightYears);

		}
	}


	[NVP_Manifest(
		Id = "A5ECF0E7-75B6-465C-A4B3-6AB38A1DA7F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsParsecs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsParsecs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsParsecs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsParsecs);

		}
	}


	[NVP_Manifest(
		Id = "BB724727-2339-468E-AF48-B31F384A5B84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsUSSurveyFeet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsUSSurveyFeet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsUSSurveyFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsUSSurveyFeet);

		}
	}


	[NVP_Manifest(
		Id = "AE34AD2F-94C7-4586-9ED3-0D2BC4B3FF96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsUSSurveyInch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsUSSurveyInch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsUSSurveyInch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsUSSurveyInch);

		}
	}


	[NVP_Manifest(
		Id = "50B20249-7D94-418F-9006-0B196E76B52B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsUSSurveyYard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsUSSurveyYard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsUSSurveyYard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsUSSurveyYard);

		}
	}


	[NVP_Manifest(
		Id = "3BD09079-71F4-4278-92A4-26D456225168", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnits.enum_acInsertUnitsUSSurveyMile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnits", 
		NodeName = "enum_acInsertUnitsUSSurveyMile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsUSSurveyMile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnits.acInsertUnitsUSSurveyMile);

		}
	}
}
