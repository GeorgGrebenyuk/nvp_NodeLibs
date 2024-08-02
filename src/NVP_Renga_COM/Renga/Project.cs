using NVP.API.Nodes;

namespace Renga.Project 
{
		[NodeInput("dynamic", typeof(object))]
		public class Project_Constructor : INode 
		{
		public Renga.IProject _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IProject;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class Project_ConstructorCast : INode 
		{
		public Renga.IProject _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IProject;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class FilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FilePath);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class HasFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasFile);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Model : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Model);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PropertyManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PropertyManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class MaterialManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MaterialManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class LayeredMaterialManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayeredMaterialManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class DataExporter : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DataExporter);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ReinforcementUnitStyleManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ReinforcementUnitStyleManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ProjectType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ProjectType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Drawings : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Drawings);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class HasUnsavedChanges : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasUnsavedChanges);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Save : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Save);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("FilePath", typeof(System.String))]
		[NodeInput("ProjectType", typeof(System.Object))]
		[NodeInput("overwrite", typeof(System.Object))]
		public class SaveAs : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SaveAs(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("FilePath", typeof(System.String))]
		[NodeInput("overwrite", typeof(System.Object))]
		public class ExportToIfc : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExportToIfc(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ProfileDescriptionManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ProfileDescriptionManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class BeamStyleManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BeamStyleManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ColumnStyleManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ColumnStyleManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("folderPath", typeof(System.String))]
		[NodeInput("overwrite", typeof(System.Object))]
		public class ExportToCsv : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExportToCsv(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ExportDrawingsToPdf : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExportDrawingsToPdf();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class SystemStyleManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SystemStyleManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PlumbingFixtureStyleManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlumbingFixtureStyleManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class EquipmentStyleManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EquipmentStyleManager);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("FilePath", typeof(System.String))]
		[NodeInput("overwrite", typeof(System.Object))]
		[NodeInput("pIfcExportSettings", typeof(System.Object))]
		public class ExportToIfc2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExportToIfc2(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ProjectInfo : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ProjectInfo);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class BuildingInfo : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BuildingInfo);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class LandPlotInfo : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LandPlotInfo);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PipeAccessoryStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PipeAccessoryStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PipeStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PipeStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PipeFittingStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PipeFittingStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class MechanicalEquipmentStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MechanicalEquipmentStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class DuctStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DuctStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class DuctFittingStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DuctFittingStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class DuctAccessoryStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DuctAccessoryStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class LightFixtureStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LightFixtureStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class WiringAccessoryStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WiringAccessoryStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ElectricDistributionBoardStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElectricDistributionBoardStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ElectricalConductorStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElectricalConductorStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ElectricalCircuitLineStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElectricalCircuitLineStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class SystemStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SystemStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PlumbingFixtureStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlumbingFixtureStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class EquipmentStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EquipmentStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Assemblies : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Assemblies);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ExportDrawingsToPdfS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExportDrawingsToPdfS();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ExportDrawingsToOpenXpsS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExportDrawingsToOpenXpsS();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Drawings2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Drawings2);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ElementStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElementStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class BeamStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BeamStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ColumnStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ColumnStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PlateStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlateStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Materials : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Materials);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class WindowStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WindowStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class DoorStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DoorStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class LayeredMaterials : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayeredMaterials);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Profiles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Profiles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class CreateOperation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateOperation);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class Topics : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Topics);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class LayoutStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayoutStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PageFormatStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PageFormatStyles);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("entityId", typeof(System.Object))]
		public class GetEntityNumberInTopic : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetEntityNumberInTopic(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("entityId", typeof(System.String))]
		public class GetEntityNumberInTopicS : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetEntityNumberInTopicS(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class JournalPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.JournalPath);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class HasActiveOperation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasActiveOperation);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("modelId", typeof(System.Object))]
		public class CreateOperationWithUndo : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CreateOperationWithUndo(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		[NodeInput("modelId", typeof(System.Object))]
		public class GetUndoStack : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetUndoStack(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class DuctAccessoryCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DuctAccessoryCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PipeAccessoryCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PipeAccessoryCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class DuctFittingCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DuctFittingCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PipeFittingCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PipeFittingCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class MechanicalEquipmentCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MechanicalEquipmentCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class EquipmentCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EquipmentCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class PlumbingFixtureCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlumbingFixtureCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class ElectricDistributionBoardCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElectricDistributionBoardCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class WiringAccessoryCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WiringAccessoryCategories);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("Project", typeof(object))]
		public class LightningFixtureCategories : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LightningFixtureCategories);

			}
		}
}
