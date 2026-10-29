public interface ITooltipProvider
{
	bool TryGetTooltip(out TooltipContent content);
}
