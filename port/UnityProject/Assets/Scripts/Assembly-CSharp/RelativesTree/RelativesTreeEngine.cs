using System.Collections.Generic;

namespace RelativesTree
{
	public class RelativesTreeEngine
	{
		private Store m_Store;

		private Options m_Options;

		public RelativesTreeEngine(List<Node> nodes, Options options)
		{
		}

		public RelData CalculateLayout()
		{
			return null;
		}

		private void ProcessMiddleDirection()
		{
		}

		private List<Family> CreateFamilyWithoutParents()
		{
			return null;
		}

		private List<Family> CreateFamiliesWithParents()
		{
			return null;
		}

		private void ProcessParentDirection()
		{
		}

		private void CreateParentFamilies(Family childFamily)
		{
		}

		private void ProcessChildDirection()
		{
		}

		private void CreateChildFamilies(Family parentFamily, Node parentNode)
		{
		}

		private void ArrangeFamiliesHorizontally(List<Family> families)
		{
		}

		private float CalculateFamilyWidth(Family family)
		{
			return 0f;
		}

		private void CorrectPositions()
		{
		}

		private void SetVerticalPositions(List<Family> families)
		{
		}

		private void CenterFamilies(List<Family> families)
		{
		}

		private RelData GenerateRelData()
		{
			return null;
		}

		private List<ExtNode> GenerateExtendedNodes(List<Family> families)
		{
			return null;
		}

		private List<Connector> GenerateConnectors(List<Family> families)
		{
			return null;
		}

		private void GenerateSpouseConnectors(Family family, List<Connector> connectors)
		{
		}

		private void GenerateParentChildConnectors(Family family, List<Connector> connectors)
		{
		}

		private CanvasSize CalculateCanvasSize(List<ExtNode> nodes)
		{
			return null;
		}

		private void ArrangeUnitsInOrder(List<Unit> units)
		{
		}

		private void SetDefaultUnitShift(Family family)
		{
		}
	}
}
