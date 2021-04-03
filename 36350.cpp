
#include <string>
#include <iostream>
#include <typeinfo>
#include <vector>
using namespace std;


template <typename T, typename U>
class Iterator {
public:
	typedef typename std::vector<T>::iterator iter_type;
	Iterator(U* p_data, bool reverse = false) : m_p_data_(p_data) {
		m_it_ = m_p_data_->m_data_.begin();
	}

	void First() {
		m_it_ = m_p_data_->m_data_.begin();
	}

	void Next() {
		m_it_++;
	}

	bool IsDone() {
		return (m_it_ == m_p_data_->m_data_.end());
	}

	iter_type Current() {
		return m_it_;
	}

private:
	U* m_p_data_;
	iter_type m_it_;
};



template <class T>
class Container {
	friend class Iterator<T, Container>;

public:
	void Add(T a) {
		m_data_.push_back(a);
	}

	Iterator<T, Container>* CreateIterator() {
		return new Iterator<T, Container>(this);
	}

private:
	std::vector<T> m_data_;
};






class Car {

private:
	string name;
	string model;
	int power;
	int speed;
	int price;

public:
	Car(string name, string model, int power,
		int speed, int price) :name(name),
		model(model), power(power), speed(speed),
		price(price) {}

	/*   setters
	void set_speed(int speed)
	{
		this->speed = speed;

	}
	void set_power(int speed)
	{
		this->power = power;

	}
	void set_price(int price)
	{
		this->price = price;
	}
	void set_name(string name)
	{
		this->name = name;
	}

	void set_model(string model)
	{
		this->model = model;
	}
	*/

	string show() {

		return "Name of car : " + name+ " Model: "+ model + " Power:" + to_string(power)
		+ " Speed: " + to_string(speed) + " Price: " + to_string(price) + "\n";
	}

};


void ClientCode() {

	Container<Car> cont;
	Car car1("Bmw", "M3", 300, 255, 32012);
	Car car2("Audi", "A4", 230, 210, 28000);
	Car car3("Volvo", "S40", 330, 260, 32012);

	cont.Add(car1);
	cont.Add(car2);
	cont.Add(car3);

	std::cout << "________________Iterator with custom Class______________________________" << std::endl;
	Iterator<Car, Container<Car>>* it = cont.CreateIterator();
	for (it->First(); !it->IsDone(); it->Next()) {
	cout << it->Current()->show() <<endl;
	}
	delete it;

}
//
//int main() {
//	ClientCode();
//	return 0;
//}


