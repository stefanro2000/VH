import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Count_Identical {
	public static void main(String[] args){
		List<String> list = new ArrayList<String>();
		list.add("abc");
		list.add("adc");
		list.add("acb");
		list.add("aba");
		list.add("adc");
		list.add("acbd");
		
		Map<String, Integer> hmap = new HashMap<String, Integer>();
		for(String temp:list){
			Integer count = hmap.get(temp);
			hmap.put(temp, (count == null)? 1 : count +1);		
		}
		printMap(hmap);
	}

	public static void printMap(Map<String, Integer> m){
		for(Map.Entry<String, Integer> entry : m.entrySet()){
			System.out.println("Key : " + entry.getKey() + " Value : " + entry.getValue());
		}
	}
}
