namespace Jikken.Presenter
{
	/*
	 * 全体の流れの制御を行うクラス
	 * やってはならないこと
	 * - Viewを直接参照する
	 *      -> ViewのIFを/Presenter/View内に定義し、それを参照する
	 * - using UnityEngineする
	 *	    -> Unity依存の処理はView内に完結させる
	 */

	public class GamePresenter { }
}
