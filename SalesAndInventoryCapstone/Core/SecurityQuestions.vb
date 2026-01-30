Public Module SecurityQuestions
    Public ReadOnly Property Items As Dictionary(Of String, String)
        Get
            Return New Dictionary(Of String, String) From {
                {"What is the name of your first school?", "first_school"},
                {"What is the name of the city where you were born?", "birth_city"},
                {"What is the name of the street you grew up on?", "childhood_street"},
                {"What was the name of your first pet?", "first_pet"},
                {"What was the make of your first car?", "first_car"},
                {"What is the name of your favorite teacher?", "favorite_teacher"},
                {"What is the name of your favorite childhood friend?", "childhood_friend"},
                {"What is your mother's maiden name?", "mothers_maiden"},
                {"What is the name of the town where you met your spouse or partner?", "met_spouse_town"},
                {"What is the name of the company where you had your first job?", "first_job_company"}
            }
        End Get
    End Property
End Module
