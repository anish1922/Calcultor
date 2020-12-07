pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
               bat "rmdir /s /q Calculator"
			   bat "git clone https://github.com/anish1922/Calcultor.git"
			   bat "dotnet build **\\Users\Lenovo\\.jenkins\\workspace\\Calculator\\Calcultor\\Calculator"
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
