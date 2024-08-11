using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

namespace Renga.enum_SelectionType
{
    public enum SelectionType
    {
        IObjectOnRoutePlacement,
        IObjectReinforcementModel,
        IObjectWithLayeredMaterial,
        IObjectWithMark,
        IObjectWithMaterial,
        IObjectWithPorts,
        IOpeningParams,
        IBeamParams,
        IColumnParams,
        IDoorParams,
        IFloorParams,
        ILine3DParams,
        IPortDuctParams,
        IPortPipeParams,
        IRouteParams,
        IWallParams,
        IWindowParams,
        IModelObject,
        ILevelObject
    }

    [NVP_Manifest(
        Text = "Объект на трассе",
        ViewType = "Default")]
    public class enum_SelectionType_IObjectOnRoutePlacement : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IObjectOnRoutePlacement);

        }
    }

    [NVP_Manifest(
        Text = "Армированный объект",
        ViewType = "Default")]
    public class enum_SelectionType_IObjectReinforcementModel : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IObjectReinforcementModel);

        }
    }

    [NVP_Manifest(
        Text = "Многослойный объект (материалы)",
        ViewType = "Default")]
    public class enum_SelectionType_IObjectWithLayeredMaterial : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IObjectWithLayeredMaterial);

        }
    }

    [NVP_Manifest(
        Text = "Объект с маркой",
        ViewType = "Default")]
    public class enum_SelectionType_IObjectWithMark : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IObjectWithMark);

        }
    }

    [NVP_Manifest(
        Text = "Объект с однослойным материалом",
        ViewType = "Default")]
    public class enum_SelectionType_IObjectWithMaterial : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IObjectWithMaterial);

        }
    }

    [NVP_Manifest(
        Text = "Объект, имеющий порты",
        ViewType = "Default")]
    public class enum_SelectionType_IObjectWithPorts : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IObjectWithPorts);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные данные об отверстии",
        ViewType = "Default")]
    public class enum_SelectionType_IOpeningParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IOpeningParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные данные о балке",
        ViewType = "Default")]
    public class enum_SelectionType_IBeamParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IBeamParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные данные о колонне",
        ViewType = "Default")]
    public class enum_SelectionType_IColumnParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IColumnParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные данные о двери",
        ViewType = "Default")]
    public class enum_SelectionType_IDoorParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IDoorParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные данные о перекрытии",
        ViewType = "Default")]
    public class enum_SelectionType_IFloorParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IFloorParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные данные о линии в 3d",
        ViewType = "Default")]
    public class enum_SelectionType_ILine3DParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.ILine3DParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные параметры о порте на воздуховоде",
        ViewType = "Default")]
    public class enum_SelectionType_IPortDuctParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IPortDuctParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные параметры о порте на трубе",
        ViewType = "Default")]
    public class enum_SelectionType_IPortPipeParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IPortPipeParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные параметры о трассе",
        ViewType = "Default")]
    public class enum_SelectionType_IRouteParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IRouteParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные параметры о стене",
        ViewType = "Default")]
    public class enum_SelectionType_IWallParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IWallParams);

        }
    }

    [NVP_Manifest(
        Text = "Расширенные параметры об окне",
        ViewType = "Default")]
    public class enum_SelectionType_IWindowParams : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IWindowParams);

        }
    }

    [NVP_Manifest(
        Text = "Объект, имеющий привязку к уровню",
        ViewType = "Default")]
    public class enum_SelectionType_ILevelObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.ILevelObject);

        }
    }

    [NVP_Manifest(
        Text = "Обычный объект модели",
        ViewType = "Default")]
    public class enum_SelectionType_IModelObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(SelectionType.IModelObject);

        }
    }
}
