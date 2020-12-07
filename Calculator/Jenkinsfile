pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
               
			   bat "git clone https://github.com/anish1922/Calcultor.git"
			   bat "dotnet build c:\\Users\\Lenovo\\.jenkins\\workspace\\Calculator\\Calcultor\\Calcultor\\"
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
