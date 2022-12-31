using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableCoin : ItemCollectableBase
{
    public bool collect = false;
    public float lerp = 5f;
    public float minDistance = 1f;

    protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins();
        collect= true;
    }
    public void Update()
    {
        if (collect)
        {
        transform.position = Vector3.Lerp(transform.position, PlayerController.Instance.transform.position, lerp * Time.deltaTime);
            if (Vector3.Distance(transform.position, PlayerController.Instance.transform.position) < minDistance)
            {
                HideItens();
                Destroy(gameObject);
            }
        }
    }
    protected virtual void HideItens()
    {
        if (graphicItem != null) graphicItem.SetActive(false);
        Invoke("HideObject", timeToHide);
    }
    protected override void Collect()
    {
        HideItens();
        OnCollect();
    }
}
