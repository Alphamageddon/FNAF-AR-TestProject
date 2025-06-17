using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	public class LightningGeneratorPath : LightningGenerator
	{
		public static readonly LightningGeneratorPath PathGeneratorInstance = new LightningGeneratorPath();

		public void GenerateLightningBoltPath(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
		{
			if (p.Points.Count < 2)
			{
				Debug.LogError("Lightning path should have at least two points");
				return;
			}
			int generations = p.Generations;
			int totalGenerations = generations;
			float num = ((generations == p.Generations) ? p.ChaosFactor : p.ChaosFactorForks);
			int num2 = p.SmoothingFactor - 1;
			LightningBoltSegmentGroup lightningBoltSegmentGroup = bolt.AddGroup();
			lightningBoltSegmentGroup.LineWidth = p.TrunkWidth;
			lightningBoltSegmentGroup.Generation = generations--;
			lightningBoltSegmentGroup.EndWidthMultiplier = p.EndWidthMultiplier;
			lightningBoltSegmentGroup.Color = p.Color;
			p.Start = p.Points[0] + start;
			p.End = p.Points[p.Points.Count - 1] + end;
			end = p.Start;
			for (int i = 1; i < p.Points.Count; i++)
			{
				start = end;
				end = p.Points[i];
				Vector3 vector = end - start;
				float num3 = PathGenerator.SquareRoot(vector.sqrMagnitude);
				if (num > 0f)
				{
					if (bolt.CameraMode == CameraMode.Perspective)
					{
						end += num3 * num * RandomDirection3D(p.Random);
					}
					else if (bolt.CameraMode == CameraMode.OrthographicXY)
					{
						end += num3 * num * RandomDirection2D(p.Random);
					}
					else
					{
						end += num3 * num * RandomDirection2DXZ(p.Random);
					}
					vector = end - start;
				}
				lightningBoltSegmentGroup.Segments.Add(new LightningBoltSegment
				{
					Start = start,
					End = end
				});
				float offsetAmount = num3 * num;
				RandomVector(bolt, ref start, ref end, offsetAmount, p.Random, out var result);
				if (ShouldCreateFork(p, generations, totalGenerations))
				{
					Vector3 vector2 = vector * p.ForkMultiplier() * num2 * 0.5f;
					Vector3 end2 = end + vector2 + result;
					GenerateLightningBoltStandard(bolt, start, end2, generations, totalGenerations, 0f, p);
				}
				if (--num2 == 0)
				{
					num2 = p.SmoothingFactor - 1;
				}
			}
		}

		protected override void OnGenerateLightningBolt(LightningBolt bolt, Vector3 start, Vector3 end, LightningBoltParameters p)
		{
			GenerateLightningBoltPath(bolt, start, end, p);
		}
	}
}
