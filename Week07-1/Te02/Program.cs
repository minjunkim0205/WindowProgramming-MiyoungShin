namespace Te02;

class Program
{
    class Info{
        public String Id { get; set; }
        public string Name { get; set; }
        public Info(string id, string name){
            Id = id;
            Name = name;
        }
        public string infoString => $"ID = {Id},\tName = {Name}";
    }
    static void Main(string[] args){
        // 1)번 
        //두 자리 난수(정수)를 key로, Info 객체를 value로 하는 딕셔너리 객체 map 선언 및 생성 - 본인작성 
        //2번) 
        //공용 읽기/쓰기 인덱서를 사용하여 딕셔너리 초기화, 키와 id는 난수 사용 
        //5개의 원소를 딕셔너리에 저장한다 – 본인 작성
        //3번) 
        //딕셔너리에 저장된 원소 개수 출력 – 본인 작성 
        //4번) 
        //foreach를 사용하여 딕셔너리에 저장된 모든 원소 출력 – 본인 작성 
        //5번) 
        // Add()를 사용하여 딕셔너리에 원소 추가, 키와 id는 난수 사용 
        //5개의 원소를 딕셔너리에 저장한다 – 본인 작성 
        //6번) 
        //딕셔너리에 저장된 원소 개수 출력 - 본인작성
        //7번) 
        //foreach를 사용하여 딕셔너리에 저장된 모든 원소 출력 - 본인작성 
        //8번) – 생성형 AI 사용하고 질의 내용과 결과를 캡쳐 하여 제출 
        //map에 저장된 Info 객체에서 중복되는 이름을 제거한 결과 출력 – 본인작성 
    } 
}