using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.2.2 fixedDeltaTime
    �½�һ��Cube,��Ӹ����������Use Grivityʧ�
    ���ű�BNUUpdate���ص������Main Camera��
    ��Cube��ҷ�������MainCamera���صĽű�(BNUUpdate)����gameObj��
    GetComponent����֪�ö���ʹ��GetComponent���Ի�ȡ���ö����ϵ����������ű�
*/
public class BNUUpdate : MonoBehaviour
{
    public GameObject gameObj;//��Ҫ��ȡ����Ϸ����
    private void FixedUpdate()
    {
        Vector3 te = gameObj.GetComponent<Rigidbody>().transform.position;//��ȡ�����λ������
        te.y += 5 * Time.fixedDeltaTime;//ʹ����ÿ����y������5����λ
        gameObj.GetComponent<Rigidbody>().transform.position = te;//ˢ��λ��
    }
}