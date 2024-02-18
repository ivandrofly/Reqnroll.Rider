using JetBrains.Annotations;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace ReSharperPlugin.ReqnrollRiderPlugin.References;

public class GherkinStepElementAccessContext([NotNull] ITreeNode element) : ElementAccessContext(element);