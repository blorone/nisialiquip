public class AnimationState {
    private Dictionary<string, object> animationStateDict;

    public object this[string key] {
        get { return animationStateDict[key]; }
        set { animationStateDict[key] = value; }
    }
}
