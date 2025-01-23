## **GiniMigren**
### **1.Overview**
The GiniMigren project leverages the Gini Algorithm and the Decision Tree algorithm to analyze migraine data using RapidMiner. This project was developed to predict migraine occurrences and evaluate the accuracy of doctors' decisions regarding the diagnosis and treatment of migraines. Additionally, a form-based application was created to calculate and assess the prediction accuracy.

### **2.Motivation**
Migraines are a prevalent and debilitating condition, and predicting their occurrence can significantly improve patient care. By utilizing the Gini Index and Decision Tree algorithms, this project aims to provide insights into the factors contributing to migraine episodes and help doctors make more accurate decisions. The goal is to facilitate early diagnosis and personalized treatment plans, improving the overall quality of healthcare for migraine patients.

### **3.Methodology**
**Gini Index and Decision Tree Algorithm**
The Gini Index is used as a criterion to measure the impurity of the data in decision trees. It helps determine how a dataset should be split at each decision node.
Decision Trees are used to model decision-making processes. These trees classify data based on certain features (such as age, lifestyle, medical history) to predict the likelihood of a migraine occurrence.
**RapidMiner**
The project was implemented using RapidMiner, a popular data mining and machine learning platform. RapidMiner's visual interface and powerful tools enabled easy data manipulation, model building, and evaluation. The Decision Tree algorithm was applied to the migraine dataset, and the Gini Index was used to assess the purity of the splits in the tree.

### **4.Migraine Dataset**
The dataset used in this project includes various factors such as:
Age,
Gender,
Lifestyle factors,
Medical history,
Triggers (e.g., stress, sleep disturbances) These factors were analyzed to predict whether a person is likely to experience a migraine.

###  **5.Application and Prediction Accuracy**
To assess the performance of the model, an application was created that allows users to input their details into a form. The application then uses the trained Decision Tree model to predict the likelihood of a migraine occurring. The accuracy of these predictions was compared to actual doctor decisions to evaluate the model's reliability.
The application provides the following functionalities:
Input Form: Users can input their information related to age, gender, lifestyle, and other relevant factors.
Prediction: The model provides a prediction based on the user's data, indicating the likelihood of experiencing a migraine.
Accuracy Calculation: The application compares the prediction with the doctor’s decision to calculate the accuracy of the model.

### **6.Results**
The project demonstrates the effectiveness of the Gini Index and Decision Trees in predicting migraine occurrences. The prediction accuracy was evaluated by comparing the model’s output with the doctor’s diagnosis. This evaluation provides insights into how well the algorithm can assist healthcare professionals in diagnosing and treating migraines.
