namespace WpfApplication1
{
    public interface ICube
    {
        string Moves { get; }
        string OptimizedMoves { get; }
        string ScrambleSequence { get; }

        /// <summary>
        /// Up face of the cube
        /// </summary>
        Face Up { get; }

        /// <summary>
        /// Front face of the cube
        /// </summary>
        Face Front { get; }

        /// <summary>
        /// Left face of the cube
        /// </summary>
        Face Left { get; }

        /// <summary>
        /// Right face of teh cube
        /// </summary>
        Face Right { get; }

        /// <summary>
        /// Down face of the cube
        /// </summary>
        Face Down { get; }

        /// <summary>
        /// Back face of the cube
        /// </summary>
        Face Back { get; }

        /// <summary>
        /// Initialize the cube to a solved state
        /// Clear moves and scamblesequence
        /// </summary>
        void Init_cube();

        /// <summary>
        /// Set the value of the cubies
        /// </summary>
        /// <param name="cubeValues">string containing cubie values</param>
        void Set_cube(string cubeValues);

        /// <summary>
        /// Make a copy of the cube
        /// Only copies values not record, moves or scramble
        /// </summary>
        /// <returns>Clone of cube</returns>
        Cube Clone();

        /// <summary>
        /// Determine if the cube is solved
        /// </summary>
        /// <returns>True if the cube is solved</returns>
        bool Issolved();

        /// <summary>
        /// Rotate the front face clockwise
        /// </summary>
        void Rotate_front_clockwise();

        /// <summary>
        /// Rotate the front face counter clockwise
        /// </summary>
        void Rotate_front_counterclockwise();

        /// <summary>
        /// Rotate the up face clockwise
        /// </summary>
        void Rotate_up_clockwise();

        /// <summary>
        /// Rotate the up face counter clockwise
        /// </summary>
        void Rotate_up_counterclockwise();

        /// <summary>
        /// Rotate the back face clockwise
        /// </summary>
        void Rotate_back_clockwise();

        /// <summary>
        /// Rotate the back face counter clockwise
        /// </summary>
        void Rotate_back_counterclockwise();

        /// <summary>
        /// Rotate the left face clockwise
        /// </summary>
        void Rotate_left_clockwise();

        /// <summary>
        /// Rotate the left face counter clockwise
        /// </summary>
        void Rotate_left_counterclockwise();

        /// <summary>
        /// Rotate the right face clockwise
        /// </summary>
        void Rotate_right_clockwise();

        /// <summary>
        /// Rotate the right face counter clockwise
        /// </summary>
        void Rotate_right_counterclockwise();

        /// <summary>
        /// Rotate the down face clockwise
        /// </summary>
        void Rotate_down_clockwise();

        /// <summary>
        /// Rotate the down face counter clockwise
        /// </summary>
        void Rotate_down_counterclockwise();

        /// <summary>
        /// Rotate the up slice clockwise
        /// </summary>
        void Rotate_upslice_clockwise();

        /// <summary>
        /// Rotate the down slice clockwise
        /// </summary>
        void Rotate_downslice_clockwise();

        /// <summary>
        /// Rotate the left slice clockwise
        /// </summary>
        void Rotate_leftslice_clockwise();

        /// <summary>
        /// Rotate the right slice clockwise
        /// </summary>
        void Rotate_rightslice_clockwise();

        /// <summary>
        /// Rotate the front slice clockwise
        /// </summary>
        void Rotate_frontslice_clockwise();

        /// <summary>
        /// Rotate the back slice clockwise
        /// </summary>
        void Rotate_backslice_clockwise();

        /// <summary>
        /// Rotate the cube up
        /// </summary>
        void Rotate_cube_up();

        /// <summary>
        /// Rotate the cube down
        /// </summary>
        void Rotate_cube_down();

        /// <summary>
        /// Rotate the cube left
        /// </summary>
        void Rotate_cube_left();

        /// <summary>
        /// Rotate the cube right
        /// </summary>
        void Rotate_cube_right();

        /// <summary>
        /// Reverse a sequence
        /// </summary>
        /// <param name="sequence">Sequence to reverse</param>
        /// <returns>Reversed sequence</returns>
        string Reverse_sequence(string sequence);

        /// <summary>
        /// Execute a sequence
        /// </summary>
        /// <param name="sequence">Sequence to execute</param>
        void Execute_sequence(string sequence);

        /// <summary>
        /// Scramble the cube
        /// Put the sequence in _scrambleSequence
        /// </summary>
        /// <param name="scramblecount">Number of moves to generate</param>
        void Scramble_cube(int scramblecount = 10);

        /// <summary>
        /// Optimzie a sequence
        /// </summary>
        /// <param name="sequence">Sequence to optimize</param>
        /// <returns>Optimize a sequence</returns>
        string Optimize_sequence(string sequence);

        /// <summary>
        /// Positions the cube so the given color is the front face
        /// </summary>
        /// <param name="color">Color of front face</param>
        void Set_front_face(FaceVal color);

        /// <summary>
        /// Positions the cube so the given color is the up face
        /// </summary>
        /// <param name="color">Color of top face</param>
        void Set_up_face(FaceVal color);

        /// <summary>
        /// Representation of the Cube colors
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}