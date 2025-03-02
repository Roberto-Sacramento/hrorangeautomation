pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/Roberto-Sacramento/hrorangeautomation.git', branch: 'master'
            }
        }

        stage('Building') {
            steps {
               script {
                    def buildType = input message: 'Select build type:', choices: 'Debug\nRelease'

                    if (buildType == 'Debug') {
                        echo "Performing Debug build"
                        sh './build.sh --debug' // Example: Pass a debug flag to your build script
                    } else if (buildType == 'Release') {
                        echo "Performing Release build"
                        sh './build.sh --release' // Example: Pass a release flag to your build script
                    }

                    // Add more advanced build logic here, such as:
                    // - Dependency management (e.g., npm install, pip install)
                    // - Artifact creation and storage
                    // - Environment-specific configurations
                    // - Build number generation
                    // - Docker image building
                } 
            }
        }

        stage('Testing') {
            steps {
                sh './test.sh' // Or your test command, such as 'mvn test'
            }
        }

        stage('Deploy') {
            steps {
                sh './deploy.sh' // Or your deployment command, such as 'kubectl apply -f deployment.yaml'
            }
        }
    }

    post {
        always {
            echo 'Pipeline completed'
        }
        success {
            echo 'Pipeline succeeded'
        }
        failure {
            echo 'Pipeline failed'
        }
    }
}