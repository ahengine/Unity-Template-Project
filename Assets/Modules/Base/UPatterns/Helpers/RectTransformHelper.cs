using UnityEngine;

namespace UPatterns
{
    public static class RectTransformHelper
    {
        public static void FullRectAnchors(this RectTransform rect)
        {
            rect.anchorMin = Vector2.zero;
            rect.anchorMax = Vector2.one;
            rect.offsetMin = Vector2.zero;
            rect.offsetMax = Vector2.zero;
            rect.localPosition = Vector3.zero;
            rect.localScale = Vector3.one;
        }

        public static void Override(this RectTransform self, RectTransform other)
        {
            self.anchoredPosition = other.anchoredPosition;
            self.sizeDelta = other.sizeDelta;
            self.anchorMin = other.anchorMin;
            self.anchorMax = other.anchorMax;
            self.pivot = other.pivot;
            self.rotation = other.rotation;
            self.localScale = other.localScale;
        }
    }
}